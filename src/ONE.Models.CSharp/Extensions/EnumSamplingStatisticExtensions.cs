using System;

namespace ONE.Models.CSharp.Extensions;

public static class EnumSamplingStatisticExtensions
{
    public static EnumHistorianAggregateType ToEnumAggregateType(this EnumSamplingStatistic enumSamplingStatistic)
    {
        switch (enumSamplingStatistic)
        {
            case EnumSamplingStatistic.SamplingStatisticAverage:
                return EnumHistorianAggregateType.Avg;
            case EnumSamplingStatistic.SamplingStatisticFirst:
                return EnumHistorianAggregateType.First;
            case EnumSamplingStatistic.SamplingStatisticLast:
                return EnumHistorianAggregateType.Last;
            default:
                throw new ArgumentException(
                    $"Cannot convert EnumSamplingStatistic {enumSamplingStatistic} to EnumHistorianAggregateType");
        }
    }
}
