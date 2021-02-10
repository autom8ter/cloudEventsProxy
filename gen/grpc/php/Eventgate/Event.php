<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: schema.proto

namespace Eventgate;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Event is a specification for describing event data
 *
 * Generated from protobuf message <code>eventgate.Event</code>
 */
class Event extends \Google\Protobuf\Internal\Message
{
    /**
     * Identifies the event. If an ID is not sent with the event, a uuid will be assigned
     *
     * Generated from protobuf field <code>string id = 1;</code>
     */
    private $id = '';
    /**
     * Identifies the channel/subject to which the event will be sent
     *
     * Generated from protobuf field <code>string channel = 2 [(.validator.field) = {</code>
     */
    private $channel = '';
    /**
     * The event payload(structured).
     *
     * Generated from protobuf field <code>.google.protobuf.Struct data = 5 [(.validator.field) = {</code>
     */
    private $data = null;
    /**
     * Arbitrary metadata about the event
     *
     * Generated from protobuf field <code>.google.protobuf.Struct metadata = 6;</code>
     */
    private $metadata = null;
    /**
     * The authentication claims of the event producer. This field is read-only & populated/overriden by the server before it is broadcasted to consumers.
     *
     * Generated from protobuf field <code>.google.protobuf.Struct claims = 7;</code>
     */
    private $claims = null;
    /**
     * Timestamp of when the occurrence happened. Must adhere to RFC 3339. If a timestamp is not sent with the event, the current time will be assigned
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp time = 20;</code>
     */
    private $time = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $id
     *           Identifies the event. If an ID is not sent with the event, a uuid will be assigned
     *     @type string $channel
     *           Identifies the channel/subject to which the event will be sent
     *     @type \Google\Protobuf\Struct $data
     *           The event payload(structured).
     *     @type \Google\Protobuf\Struct $metadata
     *           Arbitrary metadata about the event
     *     @type \Google\Protobuf\Struct $claims
     *           The authentication claims of the event producer. This field is read-only & populated/overriden by the server before it is broadcasted to consumers.
     *     @type \Google\Protobuf\Timestamp $time
     *           Timestamp of when the occurrence happened. Must adhere to RFC 3339. If a timestamp is not sent with the event, the current time will be assigned
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Schema::initOnce();
        parent::__construct($data);
    }

    /**
     * Identifies the event. If an ID is not sent with the event, a uuid will be assigned
     *
     * Generated from protobuf field <code>string id = 1;</code>
     * @return string
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     * Identifies the event. If an ID is not sent with the event, a uuid will be assigned
     *
     * Generated from protobuf field <code>string id = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setId($var)
    {
        GPBUtil::checkString($var, True);
        $this->id = $var;

        return $this;
    }

    /**
     * Identifies the channel/subject to which the event will be sent
     *
     * Generated from protobuf field <code>string channel = 2 [(.validator.field) = {</code>
     * @return string
     */
    public function getChannel()
    {
        return $this->channel;
    }

    /**
     * Identifies the channel/subject to which the event will be sent
     *
     * Generated from protobuf field <code>string channel = 2 [(.validator.field) = {</code>
     * @param string $var
     * @return $this
     */
    public function setChannel($var)
    {
        GPBUtil::checkString($var, True);
        $this->channel = $var;

        return $this;
    }

    /**
     * The event payload(structured).
     *
     * Generated from protobuf field <code>.google.protobuf.Struct data = 5 [(.validator.field) = {</code>
     * @return \Google\Protobuf\Struct
     */
    public function getData()
    {
        return $this->data;
    }

    /**
     * The event payload(structured).
     *
     * Generated from protobuf field <code>.google.protobuf.Struct data = 5 [(.validator.field) = {</code>
     * @param \Google\Protobuf\Struct $var
     * @return $this
     */
    public function setData($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Struct::class);
        $this->data = $var;

        return $this;
    }

    /**
     * Arbitrary metadata about the event
     *
     * Generated from protobuf field <code>.google.protobuf.Struct metadata = 6;</code>
     * @return \Google\Protobuf\Struct
     */
    public function getMetadata()
    {
        return $this->metadata;
    }

    /**
     * Arbitrary metadata about the event
     *
     * Generated from protobuf field <code>.google.protobuf.Struct metadata = 6;</code>
     * @param \Google\Protobuf\Struct $var
     * @return $this
     */
    public function setMetadata($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Struct::class);
        $this->metadata = $var;

        return $this;
    }

    /**
     * The authentication claims of the event producer. This field is read-only & populated/overriden by the server before it is broadcasted to consumers.
     *
     * Generated from protobuf field <code>.google.protobuf.Struct claims = 7;</code>
     * @return \Google\Protobuf\Struct
     */
    public function getClaims()
    {
        return $this->claims;
    }

    /**
     * The authentication claims of the event producer. This field is read-only & populated/overriden by the server before it is broadcasted to consumers.
     *
     * Generated from protobuf field <code>.google.protobuf.Struct claims = 7;</code>
     * @param \Google\Protobuf\Struct $var
     * @return $this
     */
    public function setClaims($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Struct::class);
        $this->claims = $var;

        return $this;
    }

    /**
     * Timestamp of when the occurrence happened. Must adhere to RFC 3339. If a timestamp is not sent with the event, the current time will be assigned
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp time = 20;</code>
     * @return \Google\Protobuf\Timestamp
     */
    public function getTime()
    {
        return $this->time;
    }

    /**
     * Timestamp of when the occurrence happened. Must adhere to RFC 3339. If a timestamp is not sent with the event, the current time will be assigned
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp time = 20;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->time = $var;

        return $this;
    }

}

