// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: aggregate_type.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Claros.Common.Core
{

    [global::ProtoBuf.ProtoContract()]
    public enum AggregateType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"AGGREGATE_UNKNOWN")]
        AggregateUnknown = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"AGGREGATE_MINIMUM")]
        AggregateMinimum = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"AGGREGATE_MAXIMUM")]
        AggregateMaximum = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"AGGREGATE_AVERAGE")]
        AggregateAverage = 3,
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192