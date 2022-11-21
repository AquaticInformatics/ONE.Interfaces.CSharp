using System;
using System.Collections.Generic;
using System.Text;

namespace ONE.Models.CSharp.Enterprise.Twin.Wizard
{
    public class Location
    {
        // Is this a default in the wizard
        public bool d { get; set; }
        // Is it possible to have multiple of these locations?
        public bool m { get; set; }
        // The id of the digital twin subtype
        public string id { get; set; }
    }
}
