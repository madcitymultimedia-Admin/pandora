using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataFactory.v2018_06_01.Pipelines;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ActivityStateConstant
{
    [Description("Active")]
    Active,

    [Description("Inactive")]
    Inactive,
}
