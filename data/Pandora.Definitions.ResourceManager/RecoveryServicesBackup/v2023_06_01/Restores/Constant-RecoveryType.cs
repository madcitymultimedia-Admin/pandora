using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2023_06_01.Restores;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum RecoveryTypeConstant
{
    [Description("AlternateLocation")]
    AlternateLocation,

    [Description("Invalid")]
    Invalid,

    [Description("Offline")]
    Offline,

    [Description("OriginalLocation")]
    OriginalLocation,

    [Description("RestoreDisks")]
    RestoreDisks,
}
