using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2021_11_01.ManagedDatabaseSensitivityLabels;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SensitivityLabelUpdateKindConstant
{
    [Description("remove")]
    Remove,

    [Description("set")]
    Set,
}
