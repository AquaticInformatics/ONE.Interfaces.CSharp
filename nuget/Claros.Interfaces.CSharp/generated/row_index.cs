// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: row_index.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Claros.Operations.Spreadsheet
{

    [global::ProtoBuf.ProtoContract()]
    public partial class RowIndex : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public uint worksheetVersion { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public global::Claros.Common.Core.TimeWindow timeWindow { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public global::Claros.Common.Core.TimeWindow utcTimeWindows { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public bool isInSpeed { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public bool isRowCooked { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public bool isColumnCooked { get; set; }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
