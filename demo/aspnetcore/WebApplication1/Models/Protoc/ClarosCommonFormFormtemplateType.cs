// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: claros_common_form_formtemplate_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace claros.protoc.Common.Form {

  /// <summary>Holder for reflection information generated from claros_common_form_formtemplate_type.proto</summary>
  public static partial class ClarosCommonFormFormtemplateTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for claros_common_form_formtemplate_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClarosCommonFormFormtemplateTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipjbGFyb3NfY29tbW9uX2Zvcm1fZm9ybXRlbXBsYXRlX3R5cGUucHJvdG8S",
            "EmNsYXJvcy5jb21tb24uZm9ybSpWChBGb3JtVGVtcGxhdGVUeXBlEg4KCkZU",
            "X1VOS05PV04QABIMCghGVF9QTEFOVBABEhEKDUZUX0xBQk9SQVRPUlkQAhIR",
            "Cg1GVF9FTlRFUlBSSVNFEANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::claros.protoc.Common.Form.FormTemplateType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum FormTemplateType {
    [pbr::OriginalName("FT_UNKNOWN")] FtUnknown = 0,
    [pbr::OriginalName("FT_PLANT")] FtPlant = 1,
    [pbr::OriginalName("FT_LABORATORY")] FtLaboratory = 2,
    [pbr::OriginalName("FT_ENTERPRISE")] FtEnterprise = 3,
  }

  #endregion

}

#endregion Designer generated code
