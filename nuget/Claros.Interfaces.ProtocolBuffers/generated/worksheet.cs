// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: worksheet.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Claros.Operations.Spreadsheet
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Worksheet : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public WorksheetType worksheetType { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<WorksheetDefinition> worksheetDefinitions { get; } = new global::System.Collections.Generic.List<WorksheetDefinition>();

        [global::ProtoBuf.ProtoMember(3, Name = @"rows")]
        public global::System.Collections.Generic.List<Row> Rows { get; } = new global::System.Collections.Generic.List<Row>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
