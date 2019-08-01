using System;
using System.IO;
using CsProto2Json.JsonGenerators;

namespace CsProto2Json
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists("samples")) Directory.CreateDirectory("samples");
            
            // spreadsheet
            var path = @"samples\spreadsheet.json";
            if (File.Exists(path)) File.Delete(path);

                using (var fs = File.OpenWrite(path))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(SpreadsheetJson.Generate());
            }

            // instrumentdata
            path = @"samples\instrumentdata.json";
            if (File.Exists(path)) File.Delete(path);

            using (var fs = File.OpenWrite(path))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(InstrumentDataJson.Generate());
            }

            // form template 
            path = @"samples\formtemplate.json";
            if (File.Exists(path)) File.Delete(path);

            using (var fs = File.OpenWrite(path))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(FormTemplateJson.Generate());
            }

            // form
            path = @"samples\form.json";
            if (File.Exists(path)) File.Delete(path);

            using (var fs = File.OpenWrite(path))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(FormJson.Generate());
            }

            // configuration
            path = @"samples\configuration.json";
            if (File.Exists(path)) File.Delete(path);

            using (var fs = File.OpenWrite(path))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(ConfigurationJson.Generate());
            }

            // recurrence
            path = @"samples\recurrence.json";
            if (File.Exists(path)) File.Delete(path);

            using (var fs = File.OpenWrite(path))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(RecurrenceJson.Generate());
            }

        }
    }
}
