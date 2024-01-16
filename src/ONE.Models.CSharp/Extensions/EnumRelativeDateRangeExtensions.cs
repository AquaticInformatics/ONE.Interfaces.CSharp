using ONE.Models.CSharp.Imposed.Enums;
using System;

namespace ONE.Models.CSharp.Extensions;

public static class EnumRelativeDateRangeExtensions
{
    public static string ToI18NKey(this EnumRelativeDateRange dateRange)
    {
        return dateRange switch
        {
            EnumRelativeDateRange.Last7Days => "LAST-7-DAYS",
            EnumRelativeDateRange.MonthToDate => "MONTH-TO-DATE",
            EnumRelativeDateRange.LastMonth => "LAST-MONTH",
            EnumRelativeDateRange.YearToDate => "YEAR-TO-DATE",
            EnumRelativeDateRange.LastYear => "LAST-YEAR",
            EnumRelativeDateRange.LastQuarter => "LAST-QUARTER",
            EnumRelativeDateRange.LastSemiAnnual => "LAST-SEMIANNUAL",
            EnumRelativeDateRange.Last12Months => "LAST-12-MONTHS",
            EnumRelativeDateRange.Today => "TODAY",
            EnumRelativeDateRange.Yesterday => "YESTERDAY",
            EnumRelativeDateRange.WeekToDate => "WEEK-TO-DATE",
            EnumRelativeDateRange.LastWeek => "LAST-WEEK",
            EnumRelativeDateRange.Last30Days => "LAST-30-DAYS",
            EnumRelativeDateRange.QuarterToDate => "QUARTER-TO-DATE",
            EnumRelativeDateRange.ThisWeek => "THIS-WEEK",
            EnumRelativeDateRange.Last14Days => "LAST-14-DAYS",
            EnumRelativeDateRange.Last60Days => "LAST-60-DAYS",
            EnumRelativeDateRange.Last90Days => "LAST-90-DAYS",
            EnumRelativeDateRange.ThisMonth => "THIS-MONTH",
            _ => throw new ArgumentOutOfRangeException(nameof(dateRange), dateRange, null)
        };
    }
}