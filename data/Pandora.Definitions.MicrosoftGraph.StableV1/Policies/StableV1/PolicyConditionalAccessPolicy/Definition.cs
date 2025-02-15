// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Policies.StableV1.PolicyConditionalAccessPolicy;

internal class Definition : ResourceDefinition
{
    public string Name => "PolicyConditionalAccessPolicy";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreatePolicyConditionalAccessPolicyOperation(),
        new DeletePolicyConditionalAccessPolicyByIdOperation(),
        new GetPolicyConditionalAccessPolicyByIdOperation(),
        new GetPolicyConditionalAccessPolicyCountOperation(),
        new ListPolicyConditionalAccessPoliciesOperation(),
        new UpdatePolicyConditionalAccessPolicyByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
