// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DelegatedAdminRelationshipRequestStatusConstant
{
    [Description("Created")]
    @created,

    [Description("Pending")]
    @pending,

    [Description("Succeeded")]
    @succeeded,

    [Description("Failed")]
    @failed,
}
