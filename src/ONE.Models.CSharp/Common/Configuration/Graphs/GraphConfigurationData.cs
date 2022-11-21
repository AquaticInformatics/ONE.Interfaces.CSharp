using System.Collections.Generic;

namespace ONE.Models.CSharp.Models.Common.Configuration.Graphs
{
    public class GraphConfigurationData
    {
        public string name { get; set; }
        public int defaultDateRange { get; set; }
        public List<int> columns { get; set; }
        public List<Series> series { get; set; }

        public class Series
        {
            public int twinId { get; set; }
            public string color { get; set; }
            public bool showLimits { get; set; }
            public string type { get; set; }
            public int axis { get; set; }

        }
    }
}
