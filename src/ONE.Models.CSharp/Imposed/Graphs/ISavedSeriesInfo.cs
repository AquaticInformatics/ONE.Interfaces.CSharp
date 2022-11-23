using ONE.Models.CSharp.Imposed.Enums;

namespace ONE.Models.CSharp.Imposed.Graphs
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
