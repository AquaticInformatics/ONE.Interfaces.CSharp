// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: enum_task_status.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Claros.Common.Task
{

    [global::ProtoBuf.ProtoContract()]
    public enum EnumTaskStatus
    {
        [global::ProtoBuf.ProtoEnum(Name = @"TASK_STATUS_UNKNOWN")]
        TaskStatusUnknown = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"TASK_STATUS_COMPLETED")]
        TaskStatusCompleted = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"TASK_STATUS_CANCELLED")]
        TaskStatusCancelled = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"TASK_STATUS_SKIPPED")]
        TaskStatusSkipped = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"TASK_STATUS_IN_PROGRESS")]
        TaskStatusInProgress = 4,
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
