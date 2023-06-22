// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: query.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace cosmos.nft.v1beta1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryBalanceRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"class_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClassId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"owner")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Owner { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryBalanceResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"amount")]
        public ulong Amount { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryOwnerRequest : global::ProtoBuf.IExtensible
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

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryOwnerResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"owner")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Owner { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QuerySupplyRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"class_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClassId { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QuerySupplyResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"amount")]
        public ulong Amount { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryNFTsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"class_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClassId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"owner")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Owner { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"pagination")]
        public global::cosmos._base.query.v1beta1.PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryNFTsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"nfts")]
        public global::System.Collections.Generic.List<Nft> Nfts { get; } = new global::System.Collections.Generic.List<Nft>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public global::cosmos._base.query.v1beta1.PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryNFTRequest : global::ProtoBuf.IExtensible
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

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryNFTResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"nft")]
        public Nft Nft { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryClassRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"class_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClassId { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryClassResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"class")]
        public Class Class { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryClassesRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pagination")]
        public global::cosmos._base.query.v1beta1.PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryClassesResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"classes")]
        public global::System.Collections.Generic.List<Class> Classes { get; } = new global::System.Collections.Generic.List<Class>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public global::cosmos._base.query.v1beta1.PageResponse Pagination { get; set; }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
