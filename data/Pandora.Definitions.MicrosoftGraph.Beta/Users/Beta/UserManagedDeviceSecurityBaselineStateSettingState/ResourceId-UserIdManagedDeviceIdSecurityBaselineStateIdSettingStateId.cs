// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Users.Beta.UserManagedDeviceSecurityBaselineStateSettingState;

internal class UserIdManagedDeviceIdSecurityBaselineStateIdSettingStateId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/users/{userId}/managedDevices/{managedDeviceId}/securityBaselineStates/{securityBaselineStateId}/settingStates/{securityBaselineSettingStateId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticUsers", "users"),
        ResourceIDSegment.UserSpecified("userId"),
        ResourceIDSegment.Static("staticManagedDevices", "managedDevices"),
        ResourceIDSegment.UserSpecified("managedDeviceId"),
        ResourceIDSegment.Static("staticSecurityBaselineStates", "securityBaselineStates"),
        ResourceIDSegment.UserSpecified("securityBaselineStateId"),
        ResourceIDSegment.Static("staticSettingStates", "settingStates"),
        ResourceIDSegment.UserSpecified("securityBaselineSettingStateId")
    };
}
