using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.KeyVault.v2023_07_01.ManagedHsmKeys;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum KeyRotationPolicyActionTypeConstant
{
    [Description("notify")]
    Notify,

    [Description("rotate")]
    Rotate,
}
