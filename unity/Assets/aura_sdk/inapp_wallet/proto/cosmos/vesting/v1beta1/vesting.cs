// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: vesting.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace cosmos.vesting.v1beta1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class BaseVestingAccount : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"base_account")]
        public global::cosmos.auth.v1beta1.BaseAccount BaseAccount { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"original_vesting")]
        public global::System.Collections.Generic.List<global::cosmos._base.v1beta1.Coin> OriginalVestings { get; } = new global::System.Collections.Generic.List<global::cosmos._base.v1beta1.Coin>();

        [global::ProtoBuf.ProtoMember(3, Name = @"delegated_free")]
        public global::System.Collections.Generic.List<global::cosmos._base.v1beta1.Coin> DelegatedFrees { get; } = new global::System.Collections.Generic.List<global::cosmos._base.v1beta1.Coin>();

        [global::ProtoBuf.ProtoMember(4, Name = @"delegated_vesting")]
        public global::System.Collections.Generic.List<global::cosmos._base.v1beta1.Coin> DelegatedVestings { get; } = new global::System.Collections.Generic.List<global::cosmos._base.v1beta1.Coin>();

        [global::ProtoBuf.ProtoMember(5, Name = @"end_time")]
        public long EndTime { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ContinuousVestingAccount : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"base_vesting_account")]
        public BaseVestingAccount BaseVestingAccount { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"start_time")]
        public long StartTime { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DelayedVestingAccount : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"base_vesting_account")]
        public BaseVestingAccount BaseVestingAccount { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Period : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"length")]
        public long Length { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"amount")]
        public global::System.Collections.Generic.List<global::cosmos._base.v1beta1.Coin> Amounts { get; } = new global::System.Collections.Generic.List<global::cosmos._base.v1beta1.Coin>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PeriodicVestingAccount : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"base_vesting_account")]
        public BaseVestingAccount BaseVestingAccount { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"start_time")]
        public long StartTime { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"vesting_periods")]
        public global::System.Collections.Generic.List<Period> VestingPeriods { get; } = new global::System.Collections.Generic.List<Period>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PermanentLockedAccount : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"base_vesting_account")]
        public BaseVestingAccount BaseVestingAccount { get; set; }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
