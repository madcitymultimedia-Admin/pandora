using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_11_01.UsageDetails;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum GenerateDetailedCostReportMetricTypeConstant
{
    [Description("ActualCost")]
    ActualCost,

    [Description("AmortizedCost")]
    AmortizedCost,
}
