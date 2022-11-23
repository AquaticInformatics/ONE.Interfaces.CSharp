using System.Collections.Generic;
using ONE.Models.CSharp.Imposed.Enums;

namespace ONE.Models.CSharp.Imposed.TwinUiDefinition
{
    public class UiDefinitionAttribute
    {
        public string definition { get; set; }
        public string key { get; set; }
        public I18NKeyTextReference I18NKeyTextReference { get; set; }
        public EnumUiElement uiElement { get; set; }
        public UiDefinitionValidator validator { get; set; }
        public List<UiAttributeOption> options { get; set; }
    }
}
