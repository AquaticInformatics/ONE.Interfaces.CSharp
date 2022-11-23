using System;

namespace ONE.Models.CSharp.Constants.TwinCategory
{
    public static class TelemetryConstants
    {
        public const int Id = 4;

        public static class InstrumentType
        {
            public const string RefId = "2a471801-f462-4248-8567-b128ae261fe7";
            public static readonly Guid Guid = new Guid(RefId);
        }
        public static class HistorianLogType
        {
            public const string RefId = "af952a3d-93b8-4d03-9b90-7f65d898de38";
            public static readonly Guid Guid = new Guid(RefId);
            public static class WimsDataConversionClientSubType
            {
                public const string RefId = "30a5e6e5-e603-408a-944e-975f4ecc9950";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class WimsDataConversionOperationSubType
            {
                public const string RefId = "a2df97e0-16ac-4dae-8bbd-b509d127cb73";
                public static readonly Guid Guid = new Guid(RefId);
            }
        }
        public static class HistorianType
        {
            public const string RefId = "76b517dd-4d94-4b9d-8be3-50f8ffaee731";
            public static readonly Guid Guid = new Guid(RefId);
            public static class FSData
            {
                public const string RefId = "15a5be60-ce3b-419d-9827-ba30cfd9b882";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class InstrumentMeasurements
            {
                public const string RefId = "c66fa8ca-57e6-48bd-bde7-7244ebff80cb";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class InstrumentLogs
            {
                public const string RefId = "c11e4895-1de4-4964-ae56-95aa94ec8f90";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class AquariusSamples
            {
                public const string RefId = "829004fc-1093-4278-827d-609614ad72d5";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class WaterTraxSamples
            {
                public const string RefId = "32dec483-6cf4-4924-a972-2cf45766e3c1";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class Logger
            {
                public const string RefId = "84bd3673-cc96-4d6e-a9f9-d146949f1514";
                public static readonly Guid Guid = new Guid(RefId);
            }
        }
        public static class ColumnType
        {
            public static class WorksheetDaily
            {
                public const string RefId = "18201416-4ebb-4c33-8881-57eace7cb27d";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class WorksheetFourHour
            {
                public const string RefId = "b8f79f8e-fa92-4cdc-9b9b-75589095e20a";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class WorksheetHour
            {
                public const string RefId = "858e695a-5bf7-4f4c-96fc-f9959a2ac01b";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class WorksheetFifteenMinute

            {
                public const string RefId = "2501b9d4-979c-49ea-9bbd-7089ab091747";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public const string RefId = "ae018857-5f27-4fe4-8117-d0cbaecb9c1e";
        }
        public static class EnterpriseType
        {
            public const string RefId = "a6c5443d-3726-4a6b-9725-2709094eaf5d";
            public static readonly Guid Guid = new Guid(RefId);
        }
    }
}
