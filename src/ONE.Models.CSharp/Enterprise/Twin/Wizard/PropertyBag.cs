using System.Collections.Generic;

namespace ONE.Models.CSharp.Enterprise.Twin.Wizard
{
    public class PropertyBag
    {
        //Twin Types to be used
        public string ty { get; set; }
        // List of Suggested Locations for this Digital Twin Sub Type
        public List<Location> ls { get; set; }
        // List of Suggested Parameters
        public List<Parameter> ps { get; set; }
        // List of Suggested Computations
    }
}
