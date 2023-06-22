// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: service.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace cosmos.tx.v1beta1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class GetTxsEventRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"events")]
        public global::System.Collections.Generic.List<string> Events { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public global::cosmos._base.query.v1beta1.PageRequest Pagination { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"order_by")]
        public OrderBy OrderBy { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetTxsEventResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"txs")]
        public global::System.Collections.Generic.List<Tx> Txs { get; } = new global::System.Collections.Generic.List<Tx>();

        [global::ProtoBuf.ProtoMember(2, Name = @"tx_responses")]
        public global::System.Collections.Generic.List<global::cosmos._base.abci.v1beta1.TxResponse> TxResponses { get; } = new global::System.Collections.Generic.List<global::cosmos._base.abci.v1beta1.TxResponse>();

        [global::ProtoBuf.ProtoMember(3, Name = @"pagination")]
        public global::cosmos._base.query.v1beta1.PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class BroadcastTxRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tx_bytes")]
        public byte[] TxBytes { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"mode")]
        public BroadcastMode Mode { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class BroadcastTxResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tx_response")]
        public global::cosmos._base.abci.v1beta1.TxResponse TxResponse { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SimulateRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tx")]
        [global::System.Obsolete]
        public Tx Tx { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"tx_bytes")]
        public byte[] TxBytes { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SimulateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"gas_info")]
        public global::cosmos._base.abci.v1beta1.GasInfo GasInfo { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"result")]
        public global::cosmos._base.abci.v1beta1.Result Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetTxRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"hash")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Hash { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetTxResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tx")]
        public Tx Tx { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"tx_response")]
        public global::cosmos._base.abci.v1beta1.TxResponse TxResponse { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetBlockWithTxsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"height")]
        public long Height { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"pagination")]
        public global::cosmos._base.query.v1beta1.PageRequest Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetBlockWithTxsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"txs")]
        public global::System.Collections.Generic.List<Tx> Txs { get; } = new global::System.Collections.Generic.List<Tx>();

        [global::ProtoBuf.ProtoMember(2, Name = @"block_id")]
        public global::tendermint.types.BlockID BlockId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"block")]
        public global::tendermint.types.Block Block { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"pagination")]
        public global::cosmos._base.query.v1beta1.PageResponse Pagination { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum OrderBy
    {
        [global::ProtoBuf.ProtoEnum(Name = @"ORDER_BY_UNSPECIFIED")]
        OrderByUnspecified = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"ORDER_BY_ASC")]
        OrderByAsc = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"ORDER_BY_DESC")]
        OrderByDesc = 2,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum BroadcastMode
    {
        [global::ProtoBuf.ProtoEnum(Name = @"BROADCAST_MODE_UNSPECIFIED")]
        BroadcastModeUnspecified = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"BROADCAST_MODE_BLOCK")]
        BroadcastModeBlock = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"BROADCAST_MODE_SYNC")]
        BroadcastModeSync = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"BROADCAST_MODE_ASYNC")]
        BroadcastModeAsync = 3,
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
