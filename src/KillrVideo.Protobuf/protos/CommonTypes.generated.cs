// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: common/common_types.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace KillrVideo.Protobuf {

  /// <summary>Holder for reflection information generated from common/common_types.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class CommonTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for common/common_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chljb21tb24vY29tbW9uX3R5cGVzLnByb3RvEhFraWxscnZpZGVvLmNvbW1v",
            "biIVCgRVdWlkEg0KBXZhbHVlGAEgASgJIhkKCFRpbWVVdWlkEg0KBXZhbHVl",
            "GAEgASgJQhaqAhNLaWxsclZpZGVvLlByb3RvYnVmYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.Protobuf.Uuid), global::KillrVideo.Protobuf.Uuid.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.Protobuf.TimeUuid), global::KillrVideo.Protobuf.TimeUuid.Parser, new[]{ "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Represents a v4 UUID/GUID
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Uuid : pb::IMessage<Uuid> {
    private static readonly pb::MessageParser<Uuid> _parser = new pb::MessageParser<Uuid>(() => new Uuid());
    public static pb::MessageParser<Uuid> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.Protobuf.CommonTypesReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Uuid() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Uuid(Uuid other) : this() {
      value_ = other.value_;
    }

    public Uuid Clone() {
      return new Uuid(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private string value_ = "";
    /// <summary>
    ///  Use string for simplicity sake since most programming languages provide a way
    ///  to parse to/from a UUID string (e.g. 'XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX')
    /// </summary>
    public string Value {
      get { return value_; }
      set {
        value_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Uuid);
    }

    public bool Equals(Uuid other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      return size;
    }

    public void MergeFrom(Uuid other) {
      if (other == null) {
        return;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Value = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Represents a v1 UUID/GUID (i.e. time-based UUID)
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class TimeUuid : pb::IMessage<TimeUuid> {
    private static readonly pb::MessageParser<TimeUuid> _parser = new pb::MessageParser<TimeUuid>(() => new TimeUuid());
    public static pb::MessageParser<TimeUuid> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.Protobuf.CommonTypesReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public TimeUuid() {
      OnConstruction();
    }

    partial void OnConstruction();

    public TimeUuid(TimeUuid other) : this() {
      value_ = other.value_;
    }

    public TimeUuid Clone() {
      return new TimeUuid(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private string value_ = "";
    /// <summary>
    ///  Just like Uuid, use string to represent TimeUuids (see Uuid comment)
    /// </summary>
    public string Value {
      get { return value_; }
      set {
        value_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as TimeUuid);
    }

    public bool Equals(TimeUuid other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      return size;
    }

    public void MergeFrom(TimeUuid other) {
      if (other == null) {
        return;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Value = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
