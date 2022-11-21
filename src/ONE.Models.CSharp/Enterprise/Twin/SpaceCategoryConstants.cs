using System;

namespace ONE.Models.CSharp.Enterprise.Twin
{
    public static class SpaceCategoryConstants
    {
        public const int Id = 2;

        public static class OperationType
        {
            public const string RefId = "e5d5ea04-64da-49c7-8887-7c6039ba239b";
            public static readonly Guid Guid = new Guid(RefId);
            public static class WasterWaterTreatmentPlantSubType
            {
                public const string RefId = "5adb3a4c-0b8b-43a8-8e68-e2de5f5a5430";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class SurfaceWaterTreatmentPlantSubType
            {
                public const string RefId = "307f753e-a67c-480a-976b-7b0eba270e27";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class DrinkingWaterTreatmentPlantSubType
            {
                public const string RefId = "36f8befe-1a75-4c0d-a618-e4885ca6beb2";
                public static readonly Guid Guid = new Guid(RefId);
            }
        }
        public static class LocationType
        {
            public const string RefId = "07bc39dc-9c17-494a-8873-65a85f380269";
            public static readonly Guid Guid = new Guid(RefId);
            public static class OtherSubType
            {
                public const string RefId = "3d8cbb58-4af8-4986-83ab-c7cdd70ec895";
                public static readonly Guid Guid = new Guid(RefId);
            }
        }
        public static class EnvironmentalMonitoringLocationType
        {
            public const string RefId = "94c566f3-3b11-42a7-bf32-48bc05f4c98a";
            public static readonly Guid Guid = new Guid(RefId);
            public static class LakeSubType
            {
                public const string RefId = "72ae7995-3ac3-471d-acb7-bd5fe1a1c959";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class UnknownSubType
            {
                public const string RefId = "d4c5662d-0fb7-4103-8c04-68a2d614e43f";
                public static readonly Guid Guid = new Guid(RefId);
            }
        }
        public static class GeographyLocationType
        {
            public const string RefId = "ed63ff2c-3f13-4584-8caa-c10f43af528a";
            public static class OceansSubType
            {
                public const string RefId = "880ad30e-ac02-4ecb-bcdf-ef9046c8ec2c";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class ContinentSubType
            {
                public const string RefId = "c2499cf5-4214-4e25-b033-a505017f345b";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class CountrySubType
            {
                public const string RefId = "bdd0cc6a-6317-43c4-9d34-cc405f0606ce";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class StateSubType
            {
                public const string RefId = "64592ee5-88d8-48da-aa93-eecb34ef7a2f";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class CitySubType
            {
                public const string RefId = "efc7ad46-d15e-4daa-a8be-5b31752966e8";
                public static readonly Guid Guid = new Guid(RefId);
            }
        }
    }
}
