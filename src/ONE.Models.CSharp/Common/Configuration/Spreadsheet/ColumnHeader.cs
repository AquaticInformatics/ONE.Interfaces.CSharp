using ONE.Models.CSharp.Enums;

namespace ONE.Models.CSharp.Models.Common.Configuration.Spreadsheet
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
