// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: ledger_column_formfield.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Claros.Common.Form
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LedgerColumnFormField : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ledgerColumnGUID { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"unit")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Unit { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string upLimit { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string lowLimit { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5)]
        public global::Claros.Common.Recurrence.Recurrence timeWindow { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"parameter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Parameter { get; set; } = "";

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
