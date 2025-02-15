// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Groups.StableV1.GroupTransitiveMember;

internal class GroupIdTransitiveMemberId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/groups/{groupId}/transitiveMembers/{directoryObjectId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticGroups", "groups"),
        ResourceIDSegment.UserSpecified("groupId"),
        ResourceIDSegment.Static("staticTransitiveMembers", "transitiveMembers"),
        ResourceIDSegment.UserSpecified("directoryObjectId")
    };
}
