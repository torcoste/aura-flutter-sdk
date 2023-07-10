// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: authz.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace cosmos.authz.v1beta1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class GenericAuthorization : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"msg")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Msg { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Grant : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"authorization")]
        public global::Google.Protobuf.WellKnownTypes.Any Authorization { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"expiration", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? Expiration { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GrantAuthorization : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"granter")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Granter { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"grantee")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Grantee { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"authorization")]
        public global::Google.Protobuf.WellKnownTypes.Any Authorization { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"expiration", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? Expiration { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GrantQueueItem : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"msg_type_urls")]
        public global::System.Collections.Generic.List<string> MsgTypeUrls { get; } = new global::System.Collections.Generic.List<string>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
