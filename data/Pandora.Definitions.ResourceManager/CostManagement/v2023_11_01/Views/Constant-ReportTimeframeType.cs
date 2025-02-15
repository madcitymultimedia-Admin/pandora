using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_11_01.Views;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ReportTimeframeTypeConstant
{
    [Description("Custom")]
    Custom,

    [Description("MonthToDate")]
    MonthToDate,

    [Description("WeekToDate")]
    WeekToDate,

    [Description("YearToDate")]
    YearToDate,
}
