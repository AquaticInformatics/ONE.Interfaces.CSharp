// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: claros_common_core_limit_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace claros.protoc.Common.Core {

  /// <summary>Holder for reflection information generated from claros_common_core_limit_type.proto</summary>
  public static partial class ClarosCommonCoreLimitTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for claros_common_core_limit_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClarosCommonCoreLimitTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNjbGFyb3NfY29tbW9uX2NvcmVfbGltaXRfdHlwZS5wcm90bxISY2xhcm9z",
            "LmNvbW1vbi5jb3JlKloKCUxpbWl0VHlwZRINCglMX1VOS05PV04QABIPCgtM",
            "X0hJR0hBTEFSTRABEg4KCkxfSElHSE5FQVIQAhINCglMX0xPV05FQVIQAxIO",
            "CgpMX0xPV0FMQVJNEARiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::claros.protoc.Common.Core.LimitType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum LimitType {
    [pbr::OriginalName("L_UNKNOWN")] LUnknown = 0,
    [pbr::OriginalName("L_HIGHALARM")] LHighalarm = 1,
    [pbr::OriginalName("L_HIGHNEAR")] LHighnear = 2,
    [pbr::OriginalName("L_LOWNEAR")] LLownear = 3,
    [pbr::OriginalName("L_LOWALARM")] LLowalarm = 4,
  }

  #endregion

}

#endregion Designer generated code
