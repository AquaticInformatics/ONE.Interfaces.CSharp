using ONE.Models.CSharp.Enums;

namespace ONE.Models.CSharp.Models.Common.Configuration.Graphs
{
    public interface ISavedSeriesInfo
    {
        uint twinId { get; set; }
        string color { get; set; }
        bool showLimits { get; set; }
        string type { get; set; }
        EnumSeriesAxis axis { get; set; }
    }
}
