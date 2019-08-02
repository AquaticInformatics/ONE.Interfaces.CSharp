using System.Reflection;
using AutoBogus;
using Claros.Common.Configuration;
using Claros.Common.Core;
using Claros.Common.Notification;
using Claros.Instrument.Measurement;
using Claros.Operations.Spreadsheet;
using Newtonsoft.Json;

namespace CsProto2Json.JsonGenerators
{
    public static class ApiResponseJson
    {

        public static string Generate()
        {
            var resultObj = new AutoFaker<ApiResponse>()
                .Generate();

            resultObj.Errors.AddRange(new AutoFaker<ApiError>().Generate(2));
            //resultObj.Contents.AddRange(new AutoFaker<ClarosContent>().Generate(2));

            resultObj.Contents.Add(new ClarosContent(){Cell = new AutoFaker<Cell>().Generate()});
            resultObj.Contents.Add(new ClarosContent(){Configuration = new AutoFaker<Configuration>().Generate()});
            resultObj.Contents.Add(new ClarosContent(){Measurements = new AutoFaker<Measurements>().Generate()});
            resultObj.Contents.Add(new ClarosContent() { Rows = new AutoFaker<Rows>().Generate() });
            resultObj.Contents.Add(new ClarosContent(){instrumentMeasurementDatas = new AutoFaker<InstrumentMeasurementDatas>().Generate()});
            resultObj.Contents.Add(new ClarosContent() {instrumentMeasurementDefinition = new AutoFaker<InstrumentMeasurementDefinition>().Generate()});
            resultObj.Contents.Add(new ClarosContent() {Configuration = new AutoFaker<Configuration>().Generate()});
            resultObj.Contents.Add(new ClarosContent() { notificationTemplate = new AutoFaker<NotificationTemplate>().Generate()});
            resultObj.Contents.Add(new ClarosContent() { rowIndices = new AutoFaker<RowIndices>().Generate()});
            resultObj.Contents.Add(new ClarosContent() { spreadsheetDefinitions = new AutoFaker<SpreadsheetDefinitions>().Generate()});
            resultObj.Contents.Add(new ClarosContent() {worksheetDefinitions = new AutoFaker<WorksheetDefinitions>().Generate()});

            var resultJson = JsonConvert.SerializeObject(resultObj);
            return resultJson;
        }


        /// <summary>
        /// Doesn't work yet
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static T GenerateType<T>() where T : class
        {
            //var obj = Activator.CreateInstance(typeof(T));
            //return (T)obj;


            var members = typeof(T).GetMembers();

            foreach (var memberInfo in members)
            {
                if ((memberInfo.MemberType & MemberTypes.Property) != 0)
                {
                    var memberType = memberInfo.ReflectedType;
                }

            }

            var obj = new AutoFaker<T>().Generate();
            return obj;
        }
    }
}
