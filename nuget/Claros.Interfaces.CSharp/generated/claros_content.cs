// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: claros_content.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Claros.Common.Core
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ClarosContent : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"measurements")]
        public Measurements Measurements
        {
            get { return __pbn__content.Is(1) ? ((Measurements)__pbn__content.Object) : default; }
            set { __pbn__content = new global::ProtoBuf.DiscriminatedUnionObject(1, value); }
        }
        public bool ShouldSerializeMeasurements() => __pbn__content.Is(1);
        public void ResetMeasurements() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__content, 1);

        private global::ProtoBuf.DiscriminatedUnionObject __pbn__content;

        [global::ProtoBuf.ProtoMember(2, Name = @"configuration")]
        public global::Claros.Common.Configuration.Configuration Configuration
        {
            get { return __pbn__content.Is(2) ? ((global::Claros.Common.Configuration.Configuration)__pbn__content.Object) : default; }
            set { __pbn__content = new global::ProtoBuf.DiscriminatedUnionObject(2, value); }
        }
        public bool ShouldSerializeConfiguration() => __pbn__content.Is(2);
        public void ResetConfiguration() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__content, 2);

        [global::ProtoBuf.ProtoMember(3, Name = @"rows")]
        public global::Claros.Operations.Spreadsheet.Rows Rows
        {
            get { return __pbn__content.Is(3) ? ((global::Claros.Operations.Spreadsheet.Rows)__pbn__content.Object) : default; }
            set { __pbn__content = new global::ProtoBuf.DiscriminatedUnionObject(3, value); }
        }
        public bool ShouldSerializeRows() => __pbn__content.Is(3);
        public void ResetRows() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__content, 3);

        [global::ProtoBuf.ProtoMember(4, Name = @"cell")]
        public global::Claros.Operations.Spreadsheet.Cell Cell
        {
            get { return __pbn__content.Is(4) ? ((global::Claros.Operations.Spreadsheet.Cell)__pbn__content.Object) : default; }
            set { __pbn__content = new global::ProtoBuf.DiscriminatedUnionObject(4, value); }
        }
        public bool ShouldSerializeCell() => __pbn__content.Is(4);
        public void ResetCell() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__content, 4);

        [global::ProtoBuf.ProtoMember(5)]
        public global::Claros.Operations.Spreadsheet.RowIndices rowIndices
        {
            get { return __pbn__content.Is(5) ? ((global::Claros.Operations.Spreadsheet.RowIndices)__pbn__content.Object) : default; }
            set { __pbn__content = new global::ProtoBuf.DiscriminatedUnionObject(5, value); }
        }
        public bool ShouldSerializerowIndices() => __pbn__content.Is(5);
        public void ResetrowIndices() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__content, 5);

        [global::ProtoBuf.ProtoMember(6)]
        public global::Claros.Operations.Spreadsheet.SpreadsheetDefinitions spreadsheetDefinitions
        {
            get { return __pbn__content.Is(6) ? ((global::Claros.Operations.Spreadsheet.SpreadsheetDefinitions)__pbn__content.Object) : default; }
            set { __pbn__content = new global::ProtoBuf.DiscriminatedUnionObject(6, value); }
        }
        public bool ShouldSerializespreadsheetDefinitions() => __pbn__content.Is(6);
        public void ResetspreadsheetDefinitions() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__content, 6);

        [global::ProtoBuf.ProtoMember(7)]
        public global::Claros.Operations.Spreadsheet.WorksheetDefinitions worksheetDefinitions
        {
            get { return __pbn__content.Is(7) ? ((global::Claros.Operations.Spreadsheet.WorksheetDefinitions)__pbn__content.Object) : default; }
            set { __pbn__content = new global::ProtoBuf.DiscriminatedUnionObject(7, value); }
        }
        public bool ShouldSerializeworksheetDefinitions() => __pbn__content.Is(7);
        public void ResetworksheetDefinitions() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__content, 7);

        [global::ProtoBuf.ProtoMember(8)]
        public global::Claros.Instrument.Measurement.InstrumentMeasurementDefinition instrumentMeasurementDefinition
        {
            get { return __pbn__content.Is(8) ? ((global::Claros.Instrument.Measurement.InstrumentMeasurementDefinition)__pbn__content.Object) : default; }
            set { __pbn__content = new global::ProtoBuf.DiscriminatedUnionObject(8, value); }
        }
        public bool ShouldSerializeinstrumentMeasurementDefinition() => __pbn__content.Is(8);
        public void ResetinstrumentMeasurementDefinition() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__content, 8);

        [global::ProtoBuf.ProtoMember(9)]
        public global::Claros.Instrument.Measurement.InstrumentMeasurementDatas instrumentMeasurementDatas
        {
            get { return __pbn__content.Is(9) ? ((global::Claros.Instrument.Measurement.InstrumentMeasurementDatas)__pbn__content.Object) : default; }
            set { __pbn__content = new global::ProtoBuf.DiscriminatedUnionObject(9, value); }
        }
        public bool ShouldSerializeinstrumentMeasurementDatas() => __pbn__content.Is(9);
        public void ResetinstrumentMeasurementDatas() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__content, 9);

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
