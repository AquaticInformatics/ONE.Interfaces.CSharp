using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONE.Models.CSharp.Enums
{
    [Obsolete("This enum is deprecated, please use EnumOneLogLevel instead.")]
    public enum EnumLogLevel
    {
        Unknown = 0,
        Fatal = 1,
        Error = 2,
        Warn = 3,
        Info = 4,
        Debug = 5,
        Trace = 6
    }
}
