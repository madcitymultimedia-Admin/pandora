using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2022_08_01.Incidents;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum IncidentStatusConstant
{
    [Description("Active")]
    Active,

    [Description("Closed")]
    Closed,

    [Description("New")]
    New,
}
