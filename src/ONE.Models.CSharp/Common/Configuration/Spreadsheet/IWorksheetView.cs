using System.Collections.Generic;

namespace ONE.Models.CSharp.Models.Common.Configuration.Spreadsheet
{
    public interface IWorksheetView
    {
        bool? canDelete { get; set; }
        bool? canEdit { get; set; }
        List<uint> columnNumbers { get; set; }
        Dictionary<uint, ColumnConfig> columns { get; set; }
        string createdOn { get; set; }
        List<dynamic> headers { get; set; }
        string id { get; set; }
        bool? isOwner { get; set; }
        string name { get; set; }
        EnumWorksheet worksheetType { get; set; }

    }
}