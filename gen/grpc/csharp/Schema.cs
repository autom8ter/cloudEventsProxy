// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: schema.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Eventgate {

  /// <summary>Holder for reflection information generated from schema.proto</summary>
  public static partial class SchemaReflection {

    #region Descriptor
    /// <summary>File descriptor for schema.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SchemaReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxzY2hlbWEucHJvdG8SCWV2ZW50Z2F0ZRocZ29vZ2xlL2FwaS9hbm5vdGF0",
            "aW9ucy5wcm90bxocZ29vZ2xlL3Byb3RvYnVmL3N0cnVjdC5wcm90bxofZ29v",
            "Z2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxoZZ29vZ2xlL3Byb3RvYnVm",
            "L2FueS5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGjZnaXRo",
            "dWIuY29tL213aXRrb3cvZ28tcHJvdG8tdmFsaWRhdG9ycy92YWxpZGF0b3Iu",
            "cHJvdG8iTAoGRmlsdGVyEhMKC3NwZWN2ZXJzaW9uGAEgASgJEg4KBnNvdXJj",
            "ZRgCIAEoCRIMCgR0eXBlGAMgASgJEg8KB3N1YmplY3QYBCABKAki1gEKD0Ns",
            "b3VkRXZlbnRJbnB1dBIbCgtzcGVjdmVyc2lvbhgCIAEoCUIG4t8fAlgBEhYK",
            "BnNvdXJjZRgDIAEoCUIG4t8fAlgBEhQKBHR5cGUYBCABKAlCBuLfHwJYARIP",
            "CgdzdWJqZWN0GAUgASgJEhIKCmRhdGFzY2hlbWEYBiABKAkSFwoPZGF0YWNv",
            "bnRlbnR0eXBlGAcgASgJEiUKBGRhdGEYCCABKAsyFy5nb29nbGUucHJvdG9i",
            "dWYuU3RydWN0EhMKC2RhdGFfYmFzZTY0GAkgASgJIq8CCgpDbG91ZEV2ZW50",
            "EhIKAmlkGAEgASgJQgbi3x8CWAESGwoLc3BlY3ZlcnNpb24YAiABKAlCBuLf",
            "HwJYARIWCgZzb3VyY2UYAyABKAlCBuLfHwJYARIUCgR0eXBlGAQgASgJQgbi",
            "3x8CWAESDwoHc3ViamVjdBgFIAEoCRISCgpkYXRhc2NoZW1hGAYgASgJEhcK",
            "D2RhdGFjb250ZW50dHlwZRgHIAEoCRIlCgRkYXRhGAggASgLMhcuZ29vZ2xl",
            "LnByb3RvYnVmLlN0cnVjdBITCgtkYXRhX2Jhc2U2NBgJIAEoCRIwCgR0aW1l",
            "GBQgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEIG4t8fAiABEhYK",
            "DmV2ZW50Z2F0ZV9hdXRoGBUgASgJMvwBChBFdmVudEdhdGVTZXJ2aWNlEkwK",
            "BFNlbmQSGi5ldmVudGdhdGUuQ2xvdWRFdmVudElucHV0GhYuZ29vZ2xlLnBy",
            "b3RvYnVmLkVtcHR5IhCC0+STAgoaBS9zZW5kOgEqElEKB1JlcXVlc3QSGi5l",
            "dmVudGdhdGUuQ2xvdWRFdmVudElucHV0GhUuZXZlbnRnYXRlLkNsb3VkRXZl",
            "bnQiE4LT5JMCDRoIL3JlcXVlc3Q6ASoSRwoHUmVjZWl2ZRIRLmV2ZW50Z2F0",
            "ZS5GaWx0ZXIaFS5ldmVudGdhdGUuQ2xvdWRFdmVudCIQgtPkkwIKEggvcmVj",
            "ZWl2ZTABQgtaCWV2ZW50Z2F0ZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Validator.ValidatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Eventgate.Filter), global::Eventgate.Filter.Parser, new[]{ "Specversion", "Source", "Type", "Subject" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Eventgate.CloudEventInput), global::Eventgate.CloudEventInput.Parser, new[]{ "Specversion", "Source", "Type", "Subject", "Dataschema", "Datacontenttype", "Data", "DataBase64" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Eventgate.CloudEvent), global::Eventgate.CloudEvent.Parser, new[]{ "Id", "Specversion", "Source", "Type", "Subject", "Dataschema", "Datacontenttype", "Data", "DataBase64", "Time", "EventgateAuth" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Filter filters cloud events
  /// </summary>
  public sealed partial class Filter : pb::IMessage<Filter> {
    private static readonly pb::MessageParser<Filter> _parser = new pb::MessageParser<Filter>(() => new Filter());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Filter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Eventgate.SchemaReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Filter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Filter(Filter other) : this() {
      specversion_ = other.specversion_;
      source_ = other.source_;
      type_ = other.type_;
      subject_ = other.subject_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Filter Clone() {
      return new Filter(this);
    }

    /// <summary>Field number for the "specversion" field.</summary>
    public const int SpecversionFieldNumber = 1;
    private string specversion_ = "";
    /// <summary>
    /// The version of the CloudEvents specification which the event uses.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Specversion {
      get { return specversion_; }
      set {
        specversion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 2;
    private string source_ = "";
    /// <summary>
    /// Identifies the context in which an event happened.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Source {
      get { return source_; }
      set {
        source_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private string type_ = "";
    /// <summary>
    /// Describes the type of event related to the originating occurrence.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "subject" field.</summary>
    public const int SubjectFieldNumber = 4;
    private string subject_ = "";
    /// <summary>
    /// Describes the subject of the event in the context of the event producer (identified by source).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Subject {
      get { return subject_; }
      set {
        subject_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Filter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Filter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Specversion != other.Specversion) return false;
      if (Source != other.Source) return false;
      if (Type != other.Type) return false;
      if (Subject != other.Subject) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Specversion.Length != 0) hash ^= Specversion.GetHashCode();
      if (Source.Length != 0) hash ^= Source.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (Subject.Length != 0) hash ^= Subject.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Specversion.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Specversion);
      }
      if (Source.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Source);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Type);
      }
      if (Subject.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Subject);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Specversion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Specversion);
      }
      if (Source.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Source);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (Subject.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Subject);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Filter other) {
      if (other == null) {
        return;
      }
      if (other.Specversion.Length != 0) {
        Specversion = other.Specversion;
      }
      if (other.Source.Length != 0) {
        Source = other.Source;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.Subject.Length != 0) {
        Subject = other.Subject;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Specversion = input.ReadString();
            break;
          }
          case 18: {
            Source = input.ReadString();
            break;
          }
          case 26: {
            Type = input.ReadString();
            break;
          }
          case 34: {
            Subject = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// CloudEventInput constructs a cloud event
  /// </summary>
  public sealed partial class CloudEventInput : pb::IMessage<CloudEventInput> {
    private static readonly pb::MessageParser<CloudEventInput> _parser = new pb::MessageParser<CloudEventInput>(() => new CloudEventInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CloudEventInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Eventgate.SchemaReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CloudEventInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CloudEventInput(CloudEventInput other) : this() {
      specversion_ = other.specversion_;
      source_ = other.source_;
      type_ = other.type_;
      subject_ = other.subject_;
      dataschema_ = other.dataschema_;
      datacontenttype_ = other.datacontenttype_;
      data_ = other.data_ != null ? other.data_.Clone() : null;
      dataBase64_ = other.dataBase64_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CloudEventInput Clone() {
      return new CloudEventInput(this);
    }

    /// <summary>Field number for the "specversion" field.</summary>
    public const int SpecversionFieldNumber = 2;
    private string specversion_ = "";
    /// <summary>
    /// The version of the CloudEvents specification which the event uses.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Specversion {
      get { return specversion_; }
      set {
        specversion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 3;
    private string source_ = "";
    /// <summary>
    /// Identifies the context in which an event happened.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Source {
      get { return source_; }
      set {
        source_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private string type_ = "";
    /// <summary>
    /// Describes the type of event related to the originating occurrence.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "subject" field.</summary>
    public const int SubjectFieldNumber = 5;
    private string subject_ = "";
    /// <summary>
    /// Describes the subject of the event in the context of the event producer (identified by source).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Subject {
      get { return subject_; }
      set {
        subject_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dataschema" field.</summary>
    public const int DataschemaFieldNumber = 6;
    private string dataschema_ = "";
    /// <summary>
    /// Identifies the schema that data adheres to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Dataschema {
      get { return dataschema_; }
      set {
        dataschema_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "datacontenttype" field.</summary>
    public const int DatacontenttypeFieldNumber = 7;
    private string datacontenttype_ = "";
    /// <summary>
    /// Content type of the data value. Must adhere to RFC 2046 format.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Datacontenttype {
      get { return datacontenttype_; }
      set {
        datacontenttype_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 8;
    private global::Google.Protobuf.WellKnownTypes.Struct data_;
    /// <summary>
    ///The event payload(structured).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    /// <summary>Field number for the "data_base64" field.</summary>
    public const int DataBase64FieldNumber = 9;
    private string dataBase64_ = "";
    /// <summary>
    /// Base64 encoded event payload. Must adhere to RFC4648.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DataBase64 {
      get { return dataBase64_; }
      set {
        dataBase64_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CloudEventInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CloudEventInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Specversion != other.Specversion) return false;
      if (Source != other.Source) return false;
      if (Type != other.Type) return false;
      if (Subject != other.Subject) return false;
      if (Dataschema != other.Dataschema) return false;
      if (Datacontenttype != other.Datacontenttype) return false;
      if (!object.Equals(Data, other.Data)) return false;
      if (DataBase64 != other.DataBase64) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Specversion.Length != 0) hash ^= Specversion.GetHashCode();
      if (Source.Length != 0) hash ^= Source.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (Subject.Length != 0) hash ^= Subject.GetHashCode();
      if (Dataschema.Length != 0) hash ^= Dataschema.GetHashCode();
      if (Datacontenttype.Length != 0) hash ^= Datacontenttype.GetHashCode();
      if (data_ != null) hash ^= Data.GetHashCode();
      if (DataBase64.Length != 0) hash ^= DataBase64.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Specversion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Specversion);
      }
      if (Source.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Source);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Type);
      }
      if (Subject.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Subject);
      }
      if (Dataschema.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Dataschema);
      }
      if (Datacontenttype.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Datacontenttype);
      }
      if (data_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Data);
      }
      if (DataBase64.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(DataBase64);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Specversion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Specversion);
      }
      if (Source.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Source);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (Subject.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Subject);
      }
      if (Dataschema.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Dataschema);
      }
      if (Datacontenttype.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Datacontenttype);
      }
      if (data_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      if (DataBase64.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DataBase64);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CloudEventInput other) {
      if (other == null) {
        return;
      }
      if (other.Specversion.Length != 0) {
        Specversion = other.Specversion;
      }
      if (other.Source.Length != 0) {
        Source = other.Source;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.Subject.Length != 0) {
        Subject = other.Subject;
      }
      if (other.Dataschema.Length != 0) {
        Dataschema = other.Dataschema;
      }
      if (other.Datacontenttype.Length != 0) {
        Datacontenttype = other.Datacontenttype;
      }
      if (other.data_ != null) {
        if (data_ == null) {
          data_ = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Data.MergeFrom(other.Data);
      }
      if (other.DataBase64.Length != 0) {
        DataBase64 = other.DataBase64;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            Specversion = input.ReadString();
            break;
          }
          case 26: {
            Source = input.ReadString();
            break;
          }
          case 34: {
            Type = input.ReadString();
            break;
          }
          case 42: {
            Subject = input.ReadString();
            break;
          }
          case 50: {
            Dataschema = input.ReadString();
            break;
          }
          case 58: {
            Datacontenttype = input.ReadString();
            break;
          }
          case 66: {
            if (data_ == null) {
              data_ = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(data_);
            break;
          }
          case 74: {
            DataBase64 = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// CloudEvent is
  /// </summary>
  public sealed partial class CloudEvent : pb::IMessage<CloudEvent> {
    private static readonly pb::MessageParser<CloudEvent> _parser = new pb::MessageParser<CloudEvent>(() => new CloudEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CloudEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Eventgate.SchemaReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CloudEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CloudEvent(CloudEvent other) : this() {
      id_ = other.id_;
      specversion_ = other.specversion_;
      source_ = other.source_;
      type_ = other.type_;
      subject_ = other.subject_;
      dataschema_ = other.dataschema_;
      datacontenttype_ = other.datacontenttype_;
      data_ = other.data_ != null ? other.data_.Clone() : null;
      dataBase64_ = other.dataBase64_;
      time_ = other.time_ != null ? other.time_.Clone() : null;
      eventgateAuth_ = other.eventgateAuth_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CloudEvent Clone() {
      return new CloudEvent(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// Identifies the event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "specversion" field.</summary>
    public const int SpecversionFieldNumber = 2;
    private string specversion_ = "";
    /// <summary>
    /// The version of the CloudEvents specification which the event uses.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Specversion {
      get { return specversion_; }
      set {
        specversion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 3;
    private string source_ = "";
    /// <summary>
    /// Identifies the context in which an event happened.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Source {
      get { return source_; }
      set {
        source_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private string type_ = "";
    /// <summary>
    /// Describes the type of event related to the originating occurrence.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "subject" field.</summary>
    public const int SubjectFieldNumber = 5;
    private string subject_ = "";
    /// <summary>
    /// Describes the subject of the event in the context of the event producer (identified by source).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Subject {
      get { return subject_; }
      set {
        subject_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dataschema" field.</summary>
    public const int DataschemaFieldNumber = 6;
    private string dataschema_ = "";
    /// <summary>
    /// Identifies the schema that data adheres to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Dataschema {
      get { return dataschema_; }
      set {
        dataschema_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "datacontenttype" field.</summary>
    public const int DatacontenttypeFieldNumber = 7;
    private string datacontenttype_ = "";
    /// <summary>
    /// Content type of the data value. Must adhere to RFC 2046 format.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Datacontenttype {
      get { return datacontenttype_; }
      set {
        datacontenttype_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 8;
    private global::Google.Protobuf.WellKnownTypes.Struct data_;
    /// <summary>
    /// The event payload(structured).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    /// <summary>Field number for the "data_base64" field.</summary>
    public const int DataBase64FieldNumber = 9;
    private string dataBase64_ = "";
    /// <summary>
    /// Base64 encoded event payload. Must adhere to RFC4648.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DataBase64 {
      get { return dataBase64_; }
      set {
        dataBase64_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 20;
    private global::Google.Protobuf.WellKnownTypes.Timestamp time_;
    /// <summary>
    /// Timestamp of when the occurrence happened. Must adhere to RFC 3339.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "eventgate_auth" field.</summary>
    public const int EventgateAuthFieldNumber = 21;
    private string eventgateAuth_ = "";
    /// <summary>
    /// Base64 encoded authentication payload(jwt.claims).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EventgateAuth {
      get { return eventgateAuth_; }
      set {
        eventgateAuth_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CloudEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CloudEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Specversion != other.Specversion) return false;
      if (Source != other.Source) return false;
      if (Type != other.Type) return false;
      if (Subject != other.Subject) return false;
      if (Dataschema != other.Dataschema) return false;
      if (Datacontenttype != other.Datacontenttype) return false;
      if (!object.Equals(Data, other.Data)) return false;
      if (DataBase64 != other.DataBase64) return false;
      if (!object.Equals(Time, other.Time)) return false;
      if (EventgateAuth != other.EventgateAuth) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Specversion.Length != 0) hash ^= Specversion.GetHashCode();
      if (Source.Length != 0) hash ^= Source.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (Subject.Length != 0) hash ^= Subject.GetHashCode();
      if (Dataschema.Length != 0) hash ^= Dataschema.GetHashCode();
      if (Datacontenttype.Length != 0) hash ^= Datacontenttype.GetHashCode();
      if (data_ != null) hash ^= Data.GetHashCode();
      if (DataBase64.Length != 0) hash ^= DataBase64.GetHashCode();
      if (time_ != null) hash ^= Time.GetHashCode();
      if (EventgateAuth.Length != 0) hash ^= EventgateAuth.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Specversion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Specversion);
      }
      if (Source.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Source);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Type);
      }
      if (Subject.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Subject);
      }
      if (Dataschema.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Dataschema);
      }
      if (Datacontenttype.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Datacontenttype);
      }
      if (data_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Data);
      }
      if (DataBase64.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(DataBase64);
      }
      if (time_ != null) {
        output.WriteRawTag(162, 1);
        output.WriteMessage(Time);
      }
      if (EventgateAuth.Length != 0) {
        output.WriteRawTag(170, 1);
        output.WriteString(EventgateAuth);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Specversion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Specversion);
      }
      if (Source.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Source);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (Subject.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Subject);
      }
      if (Dataschema.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Dataschema);
      }
      if (Datacontenttype.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Datacontenttype);
      }
      if (data_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      if (DataBase64.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DataBase64);
      }
      if (time_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Time);
      }
      if (EventgateAuth.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(EventgateAuth);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CloudEvent other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Specversion.Length != 0) {
        Specversion = other.Specversion;
      }
      if (other.Source.Length != 0) {
        Source = other.Source;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.Subject.Length != 0) {
        Subject = other.Subject;
      }
      if (other.Dataschema.Length != 0) {
        Dataschema = other.Dataschema;
      }
      if (other.Datacontenttype.Length != 0) {
        Datacontenttype = other.Datacontenttype;
      }
      if (other.data_ != null) {
        if (data_ == null) {
          data_ = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Data.MergeFrom(other.Data);
      }
      if (other.DataBase64.Length != 0) {
        DataBase64 = other.DataBase64;
      }
      if (other.time_ != null) {
        if (time_ == null) {
          time_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Time.MergeFrom(other.Time);
      }
      if (other.EventgateAuth.Length != 0) {
        EventgateAuth = other.EventgateAuth;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Specversion = input.ReadString();
            break;
          }
          case 26: {
            Source = input.ReadString();
            break;
          }
          case 34: {
            Type = input.ReadString();
            break;
          }
          case 42: {
            Subject = input.ReadString();
            break;
          }
          case 50: {
            Dataschema = input.ReadString();
            break;
          }
          case 58: {
            Datacontenttype = input.ReadString();
            break;
          }
          case 66: {
            if (data_ == null) {
              data_ = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(data_);
            break;
          }
          case 74: {
            DataBase64 = input.ReadString();
            break;
          }
          case 162: {
            if (time_ == null) {
              time_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(time_);
            break;
          }
          case 170: {
            EventgateAuth = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
