package service

import (
	"context"
	"github.com/autom8ter/machine/v2"
	stategate "github.com/autom8ter/stategate/gen/grpc/go"
	"github.com/autom8ter/stategate/internal/cache"
	"github.com/autom8ter/stategate/internal/logger"
	"github.com/autom8ter/stategate/internal/storage"
	"github.com/golang/protobuf/ptypes/empty"
	"go.uber.org/zap"
)

type Service struct {
	cache    cache.Provider
	storage  storage.Provider
	lgger    *logger.Logger
	messages machine.Machine
	events   machine.Machine
	cancel   func()
}

func NewService(ctx context.Context, storage storage.Provider, cache cache.Provider, lgger *logger.Logger) (*Service, error) {
	ctx, cancel := context.WithCancel(ctx)
	svc := &Service{
		cache:   cache,
		storage: storage,
		lgger:   lgger,
		messages: machine.New(machine.WithErrHandler(func(err error) {
			lgger.Error("message streaming error", zap.Error(err))
		})),
		events: machine.New(machine.WithErrHandler(func(err error) {
			lgger.Error("event streaming error", zap.Error(err))
		})),
		cancel: cancel,
	}
	ech, err := cache.GetEventChannel(ctx)
	if err != nil {
		return nil, err.Err
	}
	mch, err := cache.GetMessageChannel(ctx)
	if err != nil {
		return nil, err.Err
	}
	go func() {
		ctx, cancel := context.WithCancel(ctx)
		defer cancel()
		for {
			select {
			case <-ctx.Done():
				return
			case event := <-ech:
				svc.events.Publish(ctx, machine.Msg{
					Channel: eventChannelName(event.GetEntity().GetDomain(), event.GetEntity().GetType()),
					Body:    event,
				})
			}
		}
	}()
	go func() {
		ctx, cancel := context.WithCancel(ctx)
		defer cancel()
		for {
			select {
			case <-ctx.Done():
				return
			case message := <-mch:
				svc.messages.Publish(ctx, machine.Msg{
					Channel: msgChannelName(message.GetDomain(), message.GetChannel(), message.GetType()),
					Body:    message,
				})
			}
		}
	}()
	return svc, nil
}

func (s Service) Close() error {
	s.cancel()
	if err := s.cache.Close(); err != nil {
		return err
	}
	if err := s.storage.Close(); err != nil {
		return err
	}
	s.events.Close()
	s.messages.Close()
	return nil
}

func (s *Service) EventServiceServer() stategate.EventServiceServer {
	return &eventService{svc: s}
}

func (s *Service) EntityServiceServer() stategate.EntityServiceServer {
	return &entityService{svc: s}
}

func (s *Service) PeerServiceServer() stategate.PeerServiceServer {
	return &peerService{svc: s}
}

func (s *Service) CacheServiceServer() stategate.CacheServiceServer {
	return &cacheService{svc: s}
}

func (s *Service) MutexServiceServer() stategate.MutexServiceServer {
	return &mutexService{svc: s}
}

type eventService struct {
	svc *Service
}

func (e eventService) Stream(opts *stategate.StreamEventOpts, server stategate.EventService_StreamServer) error {
	return e.svc.streamEvents(opts, server)
}

func (e eventService) Search(ctx context.Context, opts *stategate.SearchEventOpts) (*stategate.Events, error) {
	return e.svc.searchEvents(ctx, opts)
}

func (e eventService) Get(ctx context.Context, ref *stategate.EventRef) (*stategate.Event, error) {
	return e.svc.getEvent(ctx, ref)
}

type entityService struct {
	svc *Service
}

func (o entityService) Set(ctx context.Context, entity *stategate.Entity) (*empty.Empty, error) {
	return o.svc.setEntity(ctx, entity)
}

func (o entityService) Edit(ctx context.Context, entity *stategate.Entity) (*stategate.Entity, error) {
	return o.svc.editEntity(ctx, entity)
}

func (o entityService) Revert(ctx context.Context, opts *stategate.EventRef) (*stategate.Entity, error) {
	return o.svc.revertEntity(ctx, opts)
}

func (o entityService) Get(ctx context.Context, ref *stategate.EntityRef) (*stategate.Entity, error) {
	return o.svc.getEntity(ctx, ref)
}

func (o entityService) Del(ctx context.Context, ref *stategate.EntityRef) (*empty.Empty, error) {
	return o.svc.delEntity(ctx, ref)
}

func (o entityService) Search(ctx context.Context, opts *stategate.SearchEntityOpts) (*stategate.Entities, error) {
	return o.svc.searchEntities(ctx, opts)
}

type peerService struct {
	svc *Service
}

func (p peerService) Broadcast(ctx context.Context, message *stategate.Message) (*empty.Empty, error) {
	return p.svc.broadcastMessage(ctx, message)
}

func (p peerService) Stream(opts *stategate.StreamMessageOpts, server stategate.PeerService_StreamServer) error {
	return p.svc.streamMessages(opts, server)
}

type cacheService struct {
	svc *Service
}

func (c cacheService) Set(ctx context.Context, value *stategate.Cache) (*empty.Empty, error) {
	return c.svc.setCache(ctx, value)
}

func (c cacheService) Get(ctx context.Context, ref *stategate.CacheRef) (*stategate.Cache, error) {
	return c.svc.getCache(ctx, ref)
}

func (c cacheService) Del(ctx context.Context, ref *stategate.CacheRef) (*empty.Empty, error) {
	return c.svc.delCache(ctx, ref)
}

type mutexService struct {
	svc *Service
}

func (m mutexService) Lock(ctx context.Context, mutex *stategate.Mutex) (*empty.Empty, error) {
	return m.svc.lockMutex(ctx, mutex)
}

func (m mutexService) Unlock(ctx context.Context, ref *stategate.MutexRef) (*empty.Empty, error) {
	return m.svc.unlockMutex(ctx, ref)
}
