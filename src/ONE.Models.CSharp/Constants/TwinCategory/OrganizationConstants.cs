using System;

namespace ONE.Models.CSharp.Constants.TwinCategory
{
    public static class OrganizationConstants
    {
        public const int Id = 1;

        public static class TenantType
        {
            public const string RefId = "0a1f9e35-fb6c-4976-9768-aeac93c84b96";
            public static readonly Guid Guid = new Guid(RefId);
            public static class DemoTenantSubType
            {
                public const string RefId = "10f3b028-12ab-4947-bcb0-b0f612efdaad";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class TestTenantSubType
            {
                public const string RefId = "6b9dc107-7dbe-44b4-b95f-aa99d0882cfa";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class CustomerTenantSubType
            {
                public const string RefId = "3c30f0fc-f780-482d-8b9a-671166bc11ca";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class PrivateWaterCompanyTenantSubType
            {
                public const string RefId = "bcc753cd-369d-4f6a-8661-252b8063fadd";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class RegionTenantSubType
            {
                public const string RefId = "53b82041-6dd5-4dc7-9c02-e9c76ab430aa";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class RemoteSupportTenantSubType
            {
                public const string RefId = "b25542d2-4e47-4646-a174-84dcc3d09b56";
                public static readonly Guid Guid = new Guid(RefId);
            }
            public static class TrojanTenantSubType
            {
                public const string RefId = "bb335a49-d027-4208-9bd9-7b4529b60f25";
                public static readonly Guid Guid = new Guid(RefId);
            }
        }
        public static class UserType
        {
            public const string RefId = "fbd28ae8-8c21-4187-b558-f027612d2e46";
            public static readonly Guid Guid = new Guid(RefId);
        }

    }
}
