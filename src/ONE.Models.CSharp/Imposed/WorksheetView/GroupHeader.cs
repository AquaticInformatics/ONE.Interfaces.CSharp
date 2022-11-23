using System.Collections.Generic;
using ONE.Models.CSharp.Imposed.Enums;

namespace ONE.Models.CSharp.Imposed.WorksheetView
{
    public class GroupHeader
    {
        public string name { get; set; }
        public List<dynamic> children { get; set; }  //(ColumnHeader | GroupHeader)
        public string groupId { get; set; }
        public EnumHeaderType HeaderType
        {
            get
            {
                return EnumHeaderType.group;
            }
        }
    }
}
