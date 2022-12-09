using System.Collections.Generic;

namespace ONE.Models.CSharp.Imposed.Wizard
{
    public class TwinPropertyBag
    {
        //Twin Types to be used
        public string ty { get; set; }
        // List of Suggested Locations for this Digital Twin Sub Type
        public List<WizardLocation> ls { get; set; }
        // List of Suggested Parameters
        public List<WizardParameter> ps { get; set; }
    }
}
