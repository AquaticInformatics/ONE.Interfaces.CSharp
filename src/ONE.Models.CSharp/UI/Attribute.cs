using System.Collections.Generic;
using ONE.Models.CSharp.Enums;

namespace ONE.Models.CSharp.UI
{
    public class Attribute
    {
        public string definition { get; set; }
        public string key { get; set; }
        public I18NKeyTextReference I18NKeyTextReference { get; set; }
        public EnumUiElement uiElement { get; set; }
        public Validator validator { get; set; }
        public List<Option> options { get; set; }
    }
}
