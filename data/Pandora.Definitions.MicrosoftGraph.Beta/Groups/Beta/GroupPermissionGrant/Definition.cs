// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupPermissionGrant;

internal class Definition : ResourceDefinition
{
    public string Name => "GroupPermissionGrant";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateGroupByIdPermissionGrantOperation(),
        new DeleteGroupByIdPermissionGrantByIdOperation(),
        new GetGroupByIdPermissionGrantByIdOperation(),
        new GetGroupByIdPermissionGrantCountOperation(),
        new ListGroupByIdPermissionGrantsOperation(),
        new UpdateGroupByIdPermissionGrantByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
