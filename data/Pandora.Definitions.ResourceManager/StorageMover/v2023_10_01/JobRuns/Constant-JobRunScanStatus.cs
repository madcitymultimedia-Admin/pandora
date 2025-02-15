using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.StorageMover.v2023_10_01.JobRuns;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum JobRunScanStatusConstant
{
    [Description("Completed")]
    Completed,

    [Description("NotStarted")]
    NotStarted,

    [Description("Scanning")]
    Scanning,
}
