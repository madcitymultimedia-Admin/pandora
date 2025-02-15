// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SecurityAlertStatusConstant
{
    [Description("Unknown")]
    @unknown,

    [Description("New")]
    @new,

    [Description("InProgress")]
    @inProgress,

    [Description("Resolved")]
    @resolved,
}
