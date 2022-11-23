using System.Collections.Generic;

namespace ONE.Models.CSharp.Imposed.Graphs
{
    public class GraphConfigurationData
    {
        public string name { get; set; }
        public int defaultDateRange { get; set; }
        public List<int> columns { get; set; }
        public List<GraphDataSeries> series { get; set; }

        
    }
}
