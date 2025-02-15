using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.StorageSync.v2022_09_01.CloudEndpointResource;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum CloudEndpointChangeEnumerationActivityStateConstant
{
    [Description("EnumerationInProgress")]
    EnumerationInProgress,

    [Description("InitialEnumerationInProgress")]
    InitialEnumerationInProgress,
}
