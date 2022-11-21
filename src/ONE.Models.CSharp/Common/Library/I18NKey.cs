using System;
using System.Collections.Generic;
using System.Text;

namespace ONE.Models.CSharp.Common.Library
{
    [Serializable]
    public class I18NKey
    {
        public I18NKey(string module, string type, string key, string value)
        {
            Module = module;
            Type = type;
            Key = key;
            Value = value;
        }
        public string Module { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
