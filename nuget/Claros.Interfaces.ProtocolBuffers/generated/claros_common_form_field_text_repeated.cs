// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: claros_common_form_field_text_repeated.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Claros.Common.Form
{

    [global::ProtoBuf.ProtoContract()]
    public partial class FormFieldTextRepeated : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"formFieldTextRepeated")]
        public global::System.Collections.Generic.List<FormFieldText> formFieldTextRepeateds { get; } = new global::System.Collections.Generic.List<FormFieldText>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
