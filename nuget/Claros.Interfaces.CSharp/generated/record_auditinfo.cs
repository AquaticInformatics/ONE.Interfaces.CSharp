// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: record_auditinfo.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Claros.Common.Core
{

    [global::ProtoBuf.ProtoContract()]
    public partial class RecordAuditInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string createdById { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2)]
        public ClarosDateTime createdOn { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string modifiedById { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4)]
        public ClarosDateTime modifiedOn { get; set; }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
