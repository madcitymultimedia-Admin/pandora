using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.AzureStackHCI.v2023_03_01.Cluster;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DiagnosticLevelConstant
{
    [Description("Basic")]
    Basic,

    [Description("Enhanced")]
    Enhanced,

    [Description("Off")]
    Off,
}
