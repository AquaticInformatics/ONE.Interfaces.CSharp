// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: formfield_worksheet_column_UTC.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Claros.Common.Form
{

    [global::ProtoBuf.ProtoContract()]
    public partial class FormFieldWorksheetColumnUTC : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string plantId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2)]
        public global::Claros.Operations.Spreadsheet.WorksheetType worksheetType { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"column")]
        public global::Claros.Operations.Spreadsheet.Column Column { get; set; }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
