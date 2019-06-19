// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: claros_instrument_data.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace claros.protogen.instrument
{

    [global::ProtoBuf.ProtoContract()]
    public partial class InstrumentData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string tenantId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string fusionId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"events")]
        public InstrumentEvent Events { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"measurements")]
        public global::System.Collections.Generic.List<InstrumentMeasurement> Measurements { get; } = new global::System.Collections.Generic.List<InstrumentMeasurement>();

        [global::ProtoBuf.ProtoMember(5, Name = @"settings")]
        [global::ProtoBuf.ProtoMap]
        public global::System.Collections.Generic.Dictionary<string, string> Settings { get; } = new global::System.Collections.Generic.Dictionary<string, string>();

        [global::ProtoBuf.ProtoMember(6, Name = @"states")]
        [global::ProtoBuf.ProtoMap]
        public global::System.Collections.Generic.Dictionary<string, string> States { get; } = new global::System.Collections.Generic.Dictionary<string, string>();

        [global::ProtoBuf.ProtoMember(7)]
        public global::claros.protogen.common.core.ClarosDateTime instrumentDataDateTime { get; set; }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
