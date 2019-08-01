// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: api_response.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Claros.Common.Core
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ApiResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"errors")]
        public global::System.Collections.Generic.List<ApiError> Errors { get; } = new global::System.Collections.Generic.List<ApiError>();

        [global::ProtoBuf.ProtoMember(2, Name = @"content")]
        public ClarosContent Content { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ApiError : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint statusCode { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"code")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Code { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"detail")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Detail { get; set; } = "";

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
