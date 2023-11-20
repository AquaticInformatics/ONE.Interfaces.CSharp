using System;

namespace ONE.Models.CSharp.Constants.TwinCategory
{
    public static class InstrumentConstants
    {
        public const int Id = 3;

        public static class ClientIngestType
        {
            public const string RefId = "9c77b2dc-1c6b-4f02-88e1-eac43692d1c0";
            public static readonly Guid Guid = new Guid(RefId);

            public static class ClientIngestWindowsServiceSubType
            {
                public const string RefId = "02d6fd74-f610-428f-8dd6-2789960e7fd7";
                public static readonly Guid Guid = new Guid(RefId);
            }

            public static class ClientIngestCloudServiceSubType
            {
                public const string RefId = "f0d9b74a-a3a5-4bd1-b727-877f0b6f436d";
                public static readonly Guid Guid = new Guid(RefId);
            }
        }

        public static class ClientUtilityType
        {
            public const string RefId = "21b4d9dc-48e0-4717-a487-6e92e0d8fcdb";
            public static readonly Guid Guid = new Guid(RefId);
            
            public static class WimsDataConversionServiceSubType
            {
                public const string RefId = "51cf4cd3-962a-48fb-a092-ae9fa003ca59";
                public static readonly Guid Guid = new Guid(RefId);
            }

            public static class AnalysisResultImportSubType
            {
                public const string RefId = "999fae16-e3e0-4a63-8aee-1294bbe124ad";
                public static readonly Guid Guid = new Guid(RefId);
            }
        }

        public static class DataSourceDriverType
        {
            public const string RefId = "3209ac8f-640b-4f68-a74b-08b670187182";
            public static readonly Guid Guid = new Guid(RefId);

            public static class DataSourceDriverTest
            {
                public const string RefId = "cafd1356-7e06-44d9-9f28-3a897fbc4cf8";
                public static readonly Guid Guid = new Guid(RefId);
            }

            public static class DataSourceDriverOpenWeatherMap
            {
                public const string RefId = "285e8e04-74d5-4a86-b1d6-c6223175bc5f";
                public static readonly Guid Guid = new Guid(RefId);
            }

            public static class DataSourceDriverCsv
            {
                public const string RefId = "049ea0cb-3a66-497d-b722-f59ac0d48745";
                public static readonly Guid Guid = new Guid(RefId);
            }

            public static class AnalyteResultImportProfile
            {
                public const string RefId = "6d9ef75f-50ff-4c08-b759-5948875f69a7";
                public static readonly Guid Guid = new Guid(RefId);
            }
        }
    }
}
