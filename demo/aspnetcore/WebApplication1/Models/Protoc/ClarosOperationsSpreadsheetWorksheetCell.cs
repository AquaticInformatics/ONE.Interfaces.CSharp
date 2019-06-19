// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: claros_operations_spreadsheet_worksheet_cell.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace claros.protoc.Operations.Spreadsheet {

  /// <summary>Holder for reflection information generated from claros_operations_spreadsheet_worksheet_cell.proto</summary>
  public static partial class ClarosOperationsSpreadsheetWorksheetCellReflection {

    #region Descriptor
    /// <summary>File descriptor for claros_operations_spreadsheet_worksheet_cell.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClarosOperationsSpreadsheetWorksheetCellReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJjbGFyb3Nfb3BlcmF0aW9uc19zcHJlYWRzaGVldF93b3Jrc2hlZXRfY2Vs",
            "bC5wcm90bxIdY2xhcm9zLm9wZXJhdGlvbnMuc3ByZWFkc2hlZXQaHWNsYXJv",
            "c19jb21tb25fY29yZV9ub3RlLnByb3RvGjZjbGFyb3Nfb3BlcmF0aW9uc19z",
            "cHJlYWRzaGVldF93b3Jrc2hlZXRfY2VsbGRhdGEucHJvdG8ifAoEQ2VsbBIQ",
            "Cghjb2x1bW5JZBgBIAEoDRInCgVub3RlcxgCIAMoCzIYLmNsYXJvcy5jb21t",
            "b24uY29yZS5Ob3RlEjkKCGNlbGxEYXRhGAMgAygLMicuY2xhcm9zLm9wZXJh",
            "dGlvbnMuc3ByZWFkc2hlZXQuQ2VsbERhdGFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::claros.protoc.Common.Core.ClarosCommonCoreNoteReflection.Descriptor, global::claros.protoc.Operations.Spreadsheet.ClarosOperationsSpreadsheetWorksheetCelldataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::claros.protoc.Operations.Spreadsheet.Cell), global::claros.protoc.Operations.Spreadsheet.Cell.Parser, new[]{ "ColumnId", "Notes", "CellData" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Cell : pb::IMessage<Cell> {
    private static readonly pb::MessageParser<Cell> _parser = new pb::MessageParser<Cell>(() => new Cell());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Cell> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::claros.protoc.Operations.Spreadsheet.ClarosOperationsSpreadsheetWorksheetCellReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Cell() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Cell(Cell other) : this() {
      columnId_ = other.columnId_;
      notes_ = other.notes_.Clone();
      cellData_ = other.cellData_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Cell Clone() {
      return new Cell(this);
    }

    /// <summary>Field number for the "columnId" field.</summary>
    public const int ColumnIdFieldNumber = 1;
    private uint columnId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ColumnId {
      get { return columnId_; }
      set {
        columnId_ = value;
      }
    }

    /// <summary>Field number for the "notes" field.</summary>
    public const int NotesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::claros.protoc.Common.Core.Note> _repeated_notes_codec
        = pb::FieldCodec.ForMessage(18, global::claros.protoc.Common.Core.Note.Parser);
    private readonly pbc::RepeatedField<global::claros.protoc.Common.Core.Note> notes_ = new pbc::RepeatedField<global::claros.protoc.Common.Core.Note>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::claros.protoc.Common.Core.Note> Notes {
      get { return notes_; }
    }

    /// <summary>Field number for the "cellData" field.</summary>
    public const int CellDataFieldNumber = 3;
    private static readonly pb::FieldCodec<global::claros.protoc.Operations.Spreadsheet.CellData> _repeated_cellData_codec
        = pb::FieldCodec.ForMessage(26, global::claros.protoc.Operations.Spreadsheet.CellData.Parser);
    private readonly pbc::RepeatedField<global::claros.protoc.Operations.Spreadsheet.CellData> cellData_ = new pbc::RepeatedField<global::claros.protoc.Operations.Spreadsheet.CellData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::claros.protoc.Operations.Spreadsheet.CellData> CellData {
      get { return cellData_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Cell);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Cell other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ColumnId != other.ColumnId) return false;
      if(!notes_.Equals(other.notes_)) return false;
      if(!cellData_.Equals(other.cellData_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ColumnId != 0) hash ^= ColumnId.GetHashCode();
      hash ^= notes_.GetHashCode();
      hash ^= cellData_.GetHashCode();
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
      if (ColumnId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ColumnId);
      }
      notes_.WriteTo(output, _repeated_notes_codec);
      cellData_.WriteTo(output, _repeated_cellData_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ColumnId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ColumnId);
      }
      size += notes_.CalculateSize(_repeated_notes_codec);
      size += cellData_.CalculateSize(_repeated_cellData_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Cell other) {
      if (other == null) {
        return;
      }
      if (other.ColumnId != 0) {
        ColumnId = other.ColumnId;
      }
      notes_.Add(other.notes_);
      cellData_.Add(other.cellData_);
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
          case 8: {
            ColumnId = input.ReadUInt32();
            break;
          }
          case 18: {
            notes_.AddEntriesFrom(input, _repeated_notes_codec);
            break;
          }
          case 26: {
            cellData_.AddEntriesFrom(input, _repeated_cellData_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
