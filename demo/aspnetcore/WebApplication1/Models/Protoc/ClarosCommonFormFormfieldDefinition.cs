// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: claros_common_form_formfield_definition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace claros.protoc.Common.Form {

  /// <summary>Holder for reflection information generated from claros_common_form_formfield_definition.proto</summary>
  public static partial class ClarosCommonFormFormfieldDefinitionReflection {

    #region Descriptor
    /// <summary>File descriptor for claros_common_form_formfield_definition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClarosCommonFormFormfieldDefinitionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1jbGFyb3NfY29tbW9uX2Zvcm1fZm9ybWZpZWxkX2RlZmluaXRpb24ucHJv",
            "dG8SEmNsYXJvcy5jb21tb24uZm9ybRorY2xhcm9zX2NvbW1vbl9mb3JtX2Zv",
            "cm1kYXRhZW50cnlfdHlwZS5wcm90bxozY2xhcm9zX2NvbW1vbl9mb3JtX2Zp",
            "ZWxkX3dvcmtzaGVldF9jb2x1bW5fVVRDLnByb3RvGixjbGFyb3NfY29tbW9u",
            "X2Zvcm1fZmllbGRfdGV4dF9yZXBlYXRlZC5wcm90byKrAgoTRm9ybUZpZWxk",
            "RGVmaW5pdGlvbhIMCgRndWlkGAEgASgJEkAKEWZvcm1EYXRhRW50cnlUeXBl",
            "GAIgASgOMiUuY2xhcm9zLmNvbW1vbi5mb3JtLkZvcm1EYXRhRW50cnlUeXBl",
            "Eh0KFWlzRGF0YUVudHJ5VHlwZUxvY2tlZBgDIAEoCBIMCgRuYW1lGAQgASgJ",
            "EkEKBmNvbHVtbhgFIAEoCzIvLmNsYXJvcy5jb21tb24uZm9ybS5Gb3JtRmll",
            "bGRXb3Jrc2hlZXRDb2x1bW5VVENIABJBCgx0ZXh0UmVwZWF0ZWQYBiABKAsy",
            "KS5jbGFyb3MuY29tbW9uLmZvcm0uRm9ybUZpZWxkVGV4dFJlcGVhdGVkSABC",
            "EQoPZmllbGREZWZpbml0aW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::claros.protoc.Common.Form.ClarosCommonFormFormdataentryTypeReflection.Descriptor, global::claros.protoc.Common.Form.ClarosCommonFormFieldWorksheetColumnUTCReflection.Descriptor, global::claros.protoc.Common.Form.ClarosCommonFormFieldTextRepeatedReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::claros.protoc.Common.Form.FormFieldDefinition), global::claros.protoc.Common.Form.FormFieldDefinition.Parser, new[]{ "Guid", "FormDataEntryType", "IsDataEntryTypeLocked", "Name", "Column", "TextRepeated" }, new[]{ "FieldDefinition" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FormFieldDefinition : pb::IMessage<FormFieldDefinition> {
    private static readonly pb::MessageParser<FormFieldDefinition> _parser = new pb::MessageParser<FormFieldDefinition>(() => new FormFieldDefinition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FormFieldDefinition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::claros.protoc.Common.Form.ClarosCommonFormFormfieldDefinitionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FormFieldDefinition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FormFieldDefinition(FormFieldDefinition other) : this() {
      guid_ = other.guid_;
      formDataEntryType_ = other.formDataEntryType_;
      isDataEntryTypeLocked_ = other.isDataEntryTypeLocked_;
      name_ = other.name_;
      switch (other.FieldDefinitionCase) {
        case FieldDefinitionOneofCase.Column:
          Column = other.Column.Clone();
          break;
        case FieldDefinitionOneofCase.TextRepeated:
          TextRepeated = other.TextRepeated.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FormFieldDefinition Clone() {
      return new FormFieldDefinition(this);
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 1;
    private string guid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Guid {
      get { return guid_; }
      set {
        guid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "formDataEntryType" field.</summary>
    public const int FormDataEntryTypeFieldNumber = 2;
    private global::claros.protoc.Common.Form.FormDataEntryType formDataEntryType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::claros.protoc.Common.Form.FormDataEntryType FormDataEntryType {
      get { return formDataEntryType_; }
      set {
        formDataEntryType_ = value;
      }
    }

    /// <summary>Field number for the "isDataEntryTypeLocked" field.</summary>
    public const int IsDataEntryTypeLockedFieldNumber = 3;
    private bool isDataEntryTypeLocked_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsDataEntryTypeLocked {
      get { return isDataEntryTypeLocked_; }
      set {
        isDataEntryTypeLocked_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "column" field.</summary>
    public const int ColumnFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::claros.protoc.Common.Form.FormFieldWorksheetColumnUTC Column {
      get { return fieldDefinitionCase_ == FieldDefinitionOneofCase.Column ? (global::claros.protoc.Common.Form.FormFieldWorksheetColumnUTC) fieldDefinition_ : null; }
      set {
        fieldDefinition_ = value;
        fieldDefinitionCase_ = value == null ? FieldDefinitionOneofCase.None : FieldDefinitionOneofCase.Column;
      }
    }

    /// <summary>Field number for the "textRepeated" field.</summary>
    public const int TextRepeatedFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::claros.protoc.Common.Form.FormFieldTextRepeated TextRepeated {
      get { return fieldDefinitionCase_ == FieldDefinitionOneofCase.TextRepeated ? (global::claros.protoc.Common.Form.FormFieldTextRepeated) fieldDefinition_ : null; }
      set {
        fieldDefinition_ = value;
        fieldDefinitionCase_ = value == null ? FieldDefinitionOneofCase.None : FieldDefinitionOneofCase.TextRepeated;
      }
    }

    private object fieldDefinition_;
    /// <summary>Enum of possible cases for the "fieldDefinition" oneof.</summary>
    public enum FieldDefinitionOneofCase {
      None = 0,
      Column = 5,
      TextRepeated = 6,
    }
    private FieldDefinitionOneofCase fieldDefinitionCase_ = FieldDefinitionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FieldDefinitionOneofCase FieldDefinitionCase {
      get { return fieldDefinitionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearFieldDefinition() {
      fieldDefinitionCase_ = FieldDefinitionOneofCase.None;
      fieldDefinition_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FormFieldDefinition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FormFieldDefinition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Guid != other.Guid) return false;
      if (FormDataEntryType != other.FormDataEntryType) return false;
      if (IsDataEntryTypeLocked != other.IsDataEntryTypeLocked) return false;
      if (Name != other.Name) return false;
      if (!object.Equals(Column, other.Column)) return false;
      if (!object.Equals(TextRepeated, other.TextRepeated)) return false;
      if (FieldDefinitionCase != other.FieldDefinitionCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Guid.Length != 0) hash ^= Guid.GetHashCode();
      if (FormDataEntryType != 0) hash ^= FormDataEntryType.GetHashCode();
      if (IsDataEntryTypeLocked != false) hash ^= IsDataEntryTypeLocked.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (fieldDefinitionCase_ == FieldDefinitionOneofCase.Column) hash ^= Column.GetHashCode();
      if (fieldDefinitionCase_ == FieldDefinitionOneofCase.TextRepeated) hash ^= TextRepeated.GetHashCode();
      hash ^= (int) fieldDefinitionCase_;
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
      if (Guid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Guid);
      }
      if (FormDataEntryType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) FormDataEntryType);
      }
      if (IsDataEntryTypeLocked != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsDataEntryTypeLocked);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Name);
      }
      if (fieldDefinitionCase_ == FieldDefinitionOneofCase.Column) {
        output.WriteRawTag(42);
        output.WriteMessage(Column);
      }
      if (fieldDefinitionCase_ == FieldDefinitionOneofCase.TextRepeated) {
        output.WriteRawTag(50);
        output.WriteMessage(TextRepeated);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Guid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Guid);
      }
      if (FormDataEntryType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FormDataEntryType);
      }
      if (IsDataEntryTypeLocked != false) {
        size += 1 + 1;
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (fieldDefinitionCase_ == FieldDefinitionOneofCase.Column) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Column);
      }
      if (fieldDefinitionCase_ == FieldDefinitionOneofCase.TextRepeated) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TextRepeated);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FormFieldDefinition other) {
      if (other == null) {
        return;
      }
      if (other.Guid.Length != 0) {
        Guid = other.Guid;
      }
      if (other.FormDataEntryType != 0) {
        FormDataEntryType = other.FormDataEntryType;
      }
      if (other.IsDataEntryTypeLocked != false) {
        IsDataEntryTypeLocked = other.IsDataEntryTypeLocked;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      switch (other.FieldDefinitionCase) {
        case FieldDefinitionOneofCase.Column:
          if (Column == null) {
            Column = new global::claros.protoc.Common.Form.FormFieldWorksheetColumnUTC();
          }
          Column.MergeFrom(other.Column);
          break;
        case FieldDefinitionOneofCase.TextRepeated:
          if (TextRepeated == null) {
            TextRepeated = new global::claros.protoc.Common.Form.FormFieldTextRepeated();
          }
          TextRepeated.MergeFrom(other.TextRepeated);
          break;
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
            Guid = input.ReadString();
            break;
          }
          case 16: {
            FormDataEntryType = (global::claros.protoc.Common.Form.FormDataEntryType) input.ReadEnum();
            break;
          }
          case 24: {
            IsDataEntryTypeLocked = input.ReadBool();
            break;
          }
          case 34: {
            Name = input.ReadString();
            break;
          }
          case 42: {
            global::claros.protoc.Common.Form.FormFieldWorksheetColumnUTC subBuilder = new global::claros.protoc.Common.Form.FormFieldWorksheetColumnUTC();
            if (fieldDefinitionCase_ == FieldDefinitionOneofCase.Column) {
              subBuilder.MergeFrom(Column);
            }
            input.ReadMessage(subBuilder);
            Column = subBuilder;
            break;
          }
          case 50: {
            global::claros.protoc.Common.Form.FormFieldTextRepeated subBuilder = new global::claros.protoc.Common.Form.FormFieldTextRepeated();
            if (fieldDefinitionCase_ == FieldDefinitionOneofCase.TextRepeated) {
              subBuilder.MergeFrom(TextRepeated);
            }
            input.ReadMessage(subBuilder);
            TextRepeated = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
