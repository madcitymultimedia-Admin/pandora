using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerService.v2022_08_02_preview.TrustedAccess;

internal class RoleBindingsGetOperation : Operations.GetOperation
{
    public override ResourceID? ResourceId() => new TrustedAccessRoleBindingId();

    public override Type? ResponseObject() => typeof(TrustedAccessRoleBindingModel);


}
