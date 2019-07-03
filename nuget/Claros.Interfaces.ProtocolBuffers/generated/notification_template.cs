// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: notification_template.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Claros.Common.Notification
{

    [global::ProtoBuf.ProtoContract()]
    public partial class NotificationTemplate : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Id { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"subject")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Subject { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"body")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Body { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4)]
        public NotificationTopic notificationTopic { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public NotificationDeliveryMethodType notificationDeliveryMethodType { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public global::Claros.Common.Core.RecordAuditInfo recordAuditInfo { get; set; }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
