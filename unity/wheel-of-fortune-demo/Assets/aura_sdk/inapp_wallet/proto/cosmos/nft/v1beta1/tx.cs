// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: tx.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace cosmos.nft.v1beta1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSend : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"class_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClassId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Id { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"sender")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Sender { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"receiver")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Receiver { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgSendResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
