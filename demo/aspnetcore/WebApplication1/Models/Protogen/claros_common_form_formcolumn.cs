// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: claros_common_form_formcolumn.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace claros.protogen.common.form
{

    [global::ProtoBuf.ProtoContract()]
    public partial class FormColumn : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"number")]
        public uint Number { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<string> formFieldIds { get; } = new global::System.Collections.Generic.List<string>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
