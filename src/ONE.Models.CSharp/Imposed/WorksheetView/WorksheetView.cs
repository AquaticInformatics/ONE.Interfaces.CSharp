using System.Collections.Generic;

namespace ONE.Models.CSharp.Imposed.WorksheetView
{
    public class WorksheetView : IWorksheetView
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool? isOwner { get; set; }
        public EnumWorksheet worksheetType { get; set; }

        public List<uint> columnNumbers { get; set; }
        public Dictionary<uint, ColumnConfig> columns { get; set; }
        public string createdOn { get; set; }
        public bool? canEdit { get; set; }
        public bool? canDelete { get; set; }
        public List<dynamic> headers { get; set; } // (ColumnHeader | GroupHeader)
    }
}
