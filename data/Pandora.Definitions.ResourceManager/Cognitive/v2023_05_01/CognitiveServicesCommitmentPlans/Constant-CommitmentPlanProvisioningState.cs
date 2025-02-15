using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Cognitive.v2023_05_01.CognitiveServicesCommitmentPlans;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum CommitmentPlanProvisioningStateConstant
{
    [Description("Accepted")]
    Accepted,

    [Description("Canceled")]
    Canceled,

    [Description("Creating")]
    Creating,

    [Description("Deleting")]
    Deleting,

    [Description("Failed")]
    Failed,

    [Description("Moving")]
    Moving,

    [Description("Succeeded")]
    Succeeded,
}
