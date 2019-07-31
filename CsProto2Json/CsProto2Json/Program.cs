using System;
using System.IO;
using CsProto2Json.JsonGenerators;

namespace CsProto2Json
{
    class Program
    {
        static void Main(string[] args)
        {
            // spreadsheet
            var path = @"C:\temp\spreadsheet.json";
            File.Delete(path);

            using (var fs = File.OpenWrite(path))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(SpreadsheetJson.Generate());
            }

            // instrumentdata
            path = @"C:\temp\instrumentdata.json";
            File.Delete(path);

            using (var fs = File.OpenWrite(path))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(InstrumentDataJson.Generate());
            }

            // form template 
            path = @"C:\temp\formtemplate.json";
            File.Delete(path);

            using (var fs = File.OpenWrite(path))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(FormTemplateJson.Generate());
            }

            // form
            path = @"C:\temp\form.json";
            File.Delete(path);

            using (var fs = File.OpenWrite(path))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(FormJson.Generate());
            }

            // configuration
            path = @"C:\temp\configuration.json";
            File.Delete(path);

            using (var fs = File.OpenWrite(path))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(ConfigurationJson.Generate());
            }

            // recurrence
            path = @"C:\temp\recurrence.json";
            File.Delete(path);

            using (var fs = File.OpenWrite(path))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(RecurrenceJson.Generate());
            }


        }
    }
}
