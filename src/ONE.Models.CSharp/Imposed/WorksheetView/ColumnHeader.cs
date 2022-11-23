using ONE.Models.CSharp.Imposed.Enums;

namespace ONE.Models.CSharp.Imposed.WorksheetView
{
    public class ColumnHeader
    {
        public uint id { get; set; }
        public EnumHeaderType HeaderType
        {
            get
            {
                return EnumHeaderType.column;
            }
        }
    }
}
