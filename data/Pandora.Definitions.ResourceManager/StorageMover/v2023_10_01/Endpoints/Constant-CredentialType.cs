using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.StorageMover.v2023_10_01.Endpoints;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum CredentialTypeConstant
{
    [Description("AzureKeyVaultSmb")]
    AzureKeyVaultSmb,
}
