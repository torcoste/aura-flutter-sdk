// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: tx.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace cosmos.staking.v1beta1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgCreateValidator : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"description")]
        public Description Description { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"commission")]
        public CommissionRates Commission { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"min_self_delegation")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MinSelfDelegation { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"delegator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"pubkey")]
        public global::Google.Protobuf.WellKnownTypes.Any Pubkey { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"value")]
        public global::cosmos._base.v1beta1.Coin Value { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgCreateValidatorResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgEditValidator : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"description")]
        public Description Description { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"commission_rate")]
        [global::System.ComponentModel.DefaultValue("")]
        public string CommissionRate { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"min_self_delegation")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MinSelfDelegation { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgEditValidatorResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgDelegate : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"amount")]
        public global::cosmos._base.v1beta1.Coin Amount { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgDelegateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgBeginRedelegate : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_src_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorSrcAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"validator_dst_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorDstAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"amount")]
        public global::cosmos._base.v1beta1.Coin Amount { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgBeginRedelegateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"completion_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? CompletionTime { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgUndelegate : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"delegator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DelegatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"validator_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ValidatorAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"amount")]
        public global::cosmos._base.v1beta1.Coin Amount { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MsgUndelegateResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"completion_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? CompletionTime { get; set; }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
