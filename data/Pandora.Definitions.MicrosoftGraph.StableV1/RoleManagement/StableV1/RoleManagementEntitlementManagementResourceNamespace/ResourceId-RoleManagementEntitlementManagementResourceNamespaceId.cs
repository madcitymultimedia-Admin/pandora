// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.RoleManagement.StableV1.RoleManagementEntitlementManagementResourceNamespace;

internal class RoleManagementEntitlementManagementResourceNamespaceId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/roleManagement/entitlementManagement/resourceNamespaces/{unifiedRbacResourceNamespaceId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticRoleManagement", "roleManagement"),
        ResourceIDSegment.Static("staticEntitlementManagement", "entitlementManagement"),
        ResourceIDSegment.Static("staticResourceNamespaces", "resourceNamespaces"),
        ResourceIDSegment.UserSpecified("unifiedRbacResourceNamespaceId")
    };
}
