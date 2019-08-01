using System;
using AutoBogus;
using Claros.Common.Configuration;
using Newtonsoft.Json;

namespace CsProto2Json.JsonGenerators
{
    public static class ConfigurationJson
    {

        public static string Generate()
        {
            var obj = new AutoFaker<Configuration>().Generate();

            obj.Privileges.Add(Guid.NewGuid().ToString(), new Rights
            {
                Create = true,
                Delete = true,
                Edit = false,
                View = true
            });

            var result = JsonConvert.SerializeObject(obj);
            return result;
        }
    }
}
