// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: form_index.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Claros.Common.Form
{

    [global::ProtoBuf.ProtoContract()]
    public partial class FormIndex : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Id { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string templateId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3)]
        public uint templateVersion { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public global::Claros.Common.Core.TimeWindow timeWindow { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public global::Claros.Common.Core.ClarosDateTime lastModified { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string creatorId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(8)]
        public bool isInSpeed { get; set; }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
