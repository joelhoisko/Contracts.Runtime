// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Connectors/server/pull_connector.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dolittle.TimeSeries.Runtime.Connectors.Grpc.Server {

  /// <summary>Holder for reflection information generated from Connectors/server/pull_connector.proto</summary>
  public static partial class PullConnectorReflection {

    #region Descriptor
    /// <summary>File descriptor for Connectors/server/pull_connector.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PullConnectorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZDb25uZWN0b3JzL3NlcnZlci9wdWxsX2Nvbm5lY3Rvci5wcm90bxIlZG9s",
            "aXR0bGUudGltZXNlcmllcy5jb25uZWN0b3JzLnNlcnZlchoRc3lzdGVtL2d1",
            "aWQucHJvdG8iSwoNUHVsbENvbm5lY3RvchIaCgJpZBgBIAEoCzIOLmRvbGl0",
            "dGxlLmd1aWQSDAoEbmFtZRgCIAEoCRIQCghpbnRlcnZhbBgDIAEoBUI1qgIy",
            "RG9saXR0bGUuVGltZVNlcmllcy5SdW50aW1lLkNvbm5lY3RvcnMuR3JwYy5T",
            "ZXJ2ZXJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::System.Protobuf.GuidReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dolittle.TimeSeries.Runtime.Connectors.Grpc.Server.PullConnector), global::Dolittle.TimeSeries.Runtime.Connectors.Grpc.Server.PullConnector.Parser, new[]{ "Id", "Name", "Interval" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PullConnector : pb::IMessage<PullConnector> {
    private static readonly pb::MessageParser<PullConnector> _parser = new pb::MessageParser<PullConnector>(() => new PullConnector());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PullConnector> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dolittle.TimeSeries.Runtime.Connectors.Grpc.Server.PullConnectorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PullConnector() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PullConnector(PullConnector other) : this() {
      id_ = other.id_ != null ? other.id_.Clone() : null;
      name_ = other.name_;
      interval_ = other.interval_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PullConnector Clone() {
      return new PullConnector(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private global::System.Protobuf.guid id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::System.Protobuf.guid Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "interval" field.</summary>
    public const int IntervalFieldNumber = 3;
    private int interval_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Interval {
      get { return interval_; }
      set {
        interval_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PullConnector);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PullConnector other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      if (Name != other.Name) return false;
      if (Interval != other.Interval) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Interval != 0) hash ^= Interval.GetHashCode();
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
      if (id_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Interval != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Interval);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Interval != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Interval);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PullConnector other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          Id = new global::System.Protobuf.guid();
        }
        Id.MergeFrom(other.Id);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Interval != 0) {
        Interval = other.Interval;
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
            if (id_ == null) {
              Id = new global::System.Protobuf.guid();
            }
            input.ReadMessage(Id);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            Interval = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
