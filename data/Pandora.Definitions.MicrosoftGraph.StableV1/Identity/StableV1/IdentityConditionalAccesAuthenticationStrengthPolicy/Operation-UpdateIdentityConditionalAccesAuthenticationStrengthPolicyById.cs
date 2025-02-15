// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Identity.StableV1.IdentityConditionalAccesAuthenticationStrengthPolicy;

internal class UpdateIdentityConditionalAccesAuthenticationStrengthPolicyByIdOperation : Operations.PatchOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(AuthenticationStrengthPolicyModel);
    public override ResourceID? ResourceId() => new IdentityConditionalAccesAuthenticationStrengthPolicyId();
    public override Type? ResponseObject() => typeof(AuthenticationStrengthPolicyModel);
    public override string? UriSuffix() => null;
}
