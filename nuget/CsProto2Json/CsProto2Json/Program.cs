using System;
using System.IO;

namespace CsProto2Json
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\temp\spreadsheet.json";
            File.Delete(path);

            using (var fs = File.OpenWrite(path))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(SpreadsheetJson.Generate());
            }

            path = @"C:\temp\instrumentdata.json";
            File.Delete(path);

            using (var fs = File.OpenWrite(path))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(InstrumentDataJson.Generate());
            }
        }
    }
}
