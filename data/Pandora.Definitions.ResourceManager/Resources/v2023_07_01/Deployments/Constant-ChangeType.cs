using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Resources.v2023_07_01.Deployments;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ChangeTypeConstant
{
    [Description("Create")]
    Create,

    [Description("Delete")]
    Delete,

    [Description("Deploy")]
    Deploy,

    [Description("Ignore")]
    Ignore,

    [Description("Modify")]
    Modify,

    [Description("NoChange")]
    NoChange,

    [Description("Unsupported")]
    Unsupported,
}
