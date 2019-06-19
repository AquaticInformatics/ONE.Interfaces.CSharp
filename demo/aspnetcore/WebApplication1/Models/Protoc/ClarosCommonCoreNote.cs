// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: claros_common_core_note.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace claros.protoc.Common.Core {

  /// <summary>Holder for reflection information generated from claros_common_core_note.proto</summary>
  public static partial class ClarosCommonCoreNoteReflection {

    #region Descriptor
    /// <summary>File descriptor for claros_common_core_note.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClarosCommonCoreNoteReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1jbGFyb3NfY29tbW9uX2NvcmVfbm90ZS5wcm90bxISY2xhcm9zLmNvbW1v",
            "bi5jb3JlGidjbGFyb3NfY29tbW9uX2NvcmVfY2xhcm9zZGF0ZXRpbWUucHJv",
            "dG8iZwoETm90ZRIKCgJpZBgBIAEoCRI1Cgl0aW1lU3RhbXAYBCABKAsyIi5j",
            "bGFyb3MuY29tbW9uLmNvcmUuQ2xhcm9zRGF0ZVRpbWUSDgoGdXNlcklkGAUg",
            "ASgJEgwKBHRleHQYBiABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::claros.protoc.Common.Core.ClarosCommonCoreClarosdatetimeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::claros.protoc.Common.Core.Note), global::claros.protoc.Common.Core.Note.Parser, new[]{ "Id", "TimeStamp", "UserId", "Text" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Note : pb::IMessage<Note> {
    private static readonly pb::MessageParser<Note> _parser = new pb::MessageParser<Note>(() => new Note());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Note> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::claros.protoc.Common.Core.ClarosCommonCoreNoteReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Note() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Note(Note other) : this() {
      id_ = other.id_;
      timeStamp_ = other.timeStamp_ != null ? other.timeStamp_.Clone() : null;
      userId_ = other.userId_;
      text_ = other.text_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Note Clone() {
      return new Note(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "timeStamp" field.</summary>
    public const int TimeStampFieldNumber = 4;
    private global::claros.protoc.Common.Core.ClarosDateTime timeStamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::claros.protoc.Common.Core.ClarosDateTime TimeStamp {
      get { return timeStamp_; }
      set {
        timeStamp_ = value;
      }
    }

    /// <summary>Field number for the "userId" field.</summary>
    public const int UserIdFieldNumber = 5;
    private string userId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 6;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Note);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Note other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(TimeStamp, other.TimeStamp)) return false;
      if (UserId != other.UserId) return false;
      if (Text != other.Text) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (timeStamp_ != null) hash ^= TimeStamp.GetHashCode();
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (Text.Length != 0) hash ^= Text.GetHashCode();
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
      if (timeStamp_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(TimeStamp);
      }
      if (UserId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(UserId);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Text);
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
      if (timeStamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TimeStamp);
      }
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Note other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.timeStamp_ != null) {
        if (timeStamp_ == null) {
          TimeStamp = new global::claros.protoc.Common.Core.ClarosDateTime();
        }
        TimeStamp.MergeFrom(other.TimeStamp);
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
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
          case 34: {
            if (timeStamp_ == null) {
              TimeStamp = new global::claros.protoc.Common.Core.ClarosDateTime();
            }
            input.ReadMessage(TimeStamp);
            break;
          }
          case 42: {
            UserId = input.ReadString();
            break;
          }
          case 50: {
            Text = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
