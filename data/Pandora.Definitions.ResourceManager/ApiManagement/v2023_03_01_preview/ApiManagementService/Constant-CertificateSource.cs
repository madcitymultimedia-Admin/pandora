using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.ApiManagementService;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum CertificateSourceConstant
{
    [Description("BuiltIn")]
    BuiltIn,

    [Description("Custom")]
    Custom,

    [Description("KeyVault")]
    KeyVault,

    [Description("Managed")]
    Managed,
}
