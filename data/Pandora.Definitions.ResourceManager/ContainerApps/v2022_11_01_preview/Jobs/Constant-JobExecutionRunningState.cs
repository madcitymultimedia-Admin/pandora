using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ContainerApps.v2022_11_01_preview.Jobs;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum JobExecutionRunningStateConstant
{
    [Description("Degraded")]
    Degraded,

    [Description("Failed")]
    Failed,

    [Description("Processing")]
    Processing,

    [Description("Running")]
    Running,

    [Description("Stopped")]
    Stopped,

    [Description("Succeeded")]
    Succeeded,

    [Description("Unknown")]
    Unknown,
}
