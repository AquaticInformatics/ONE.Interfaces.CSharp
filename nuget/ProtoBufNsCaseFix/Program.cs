using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Linq;
using System.Reflection.Metadata.Ecma335;


namespace ProtoBufNsCaseFix
{
    class Program
    {
        /// <summary>
        /// This tool only assists in fixing the namespace capitalization for the generated classes. Manual changes are
        /// still needed after running this tool but it should cut down on the amount of manual effort
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // Read all namespaces and collect them 
            var namespaces = new Dictionary<string, string>();

            // HACK - Need to find a better way than hard coding this path
            var files = Directory.EnumerateFiles(
                @"C:\code\claros.interfaces.csharp\nuget\Claros.Interfaces.ProtocolBuffers\generated");
                


            // Extract the namespaces from the files and TitleCase them (ex. claros.common.example -> Claros.Common.Example)
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            foreach (var file in files)
            {
                ExtractNamespaces(file).ForEach(x =>namespaces.TryAdd(x, myTI.ToTitleCase(x)));
            }
            
            foreach (var file in files)
            {
                TitleCaseNamespaces(file, namespaces);
            }
        }

        private static void TitleCaseNamespaces(string filePath, Dictionary<string, string> namespaces)
        {
            var fileText = File.ReadAllText(filePath);

            foreach (var ns in namespaces)
            {
                fileText = fileText.Replace(ns.Key, ns.Value);
            }

            using (var fs = File.OpenWrite(filePath))
            using (var sr = new StreamWriter(fs))
            {
                sr.Write(fileText);
                sr.Flush();
            }
        }

        private static List<string> ExtractNamespaces(string file)
        {
            var result = new List<string>();

            var lines = File.ReadAllLines(file);

            result = lines.Where(x => x.StartsWith("namespace")).Select(x => x.Split(" ")[1]).ToList();

            // TODO - Need to handle cases where full namespaces used with types are used but not in the namespaces. The below block doesn't work as expected
            //var globals = lines.Where(x => x.Contains("global::claros", StringComparison.OrdinalIgnoreCase)).Select(x=> x.Trim().Split(' ')[1].Replace("global::", "")).ToList();
            //result.AddRange(globals);

            return result;
        }
    }
}
