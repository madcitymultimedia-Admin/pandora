using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Cognitive.v2023_05_01.Models;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ModelLifecycleStatusConstant
{
    [Description("GenerallyAvailable")]
    GenerallyAvailable,

    [Description("Preview")]
    Preview,
}
