using AutoBogus;
using Claros.Common.Recurrence;
using Newtonsoft.Json;

namespace CsProto2Json.JsonGenerators
{
    public static class RecurrenceJson
    {

        public static string Generate()
        {
            var obj = new AutoFaker<Recurrence>().Generate();

            var result = JsonConvert.SerializeObject(obj);

            return result;
        }
    }
}
