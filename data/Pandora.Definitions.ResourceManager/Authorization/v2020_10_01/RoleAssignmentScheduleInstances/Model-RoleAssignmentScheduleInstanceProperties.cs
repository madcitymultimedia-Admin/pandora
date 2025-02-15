using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Authorization.v2020_10_01.RoleAssignmentScheduleInstances;


internal class RoleAssignmentScheduleInstancePropertiesModel
{
    [JsonPropertyName("assignmentType")]
    public AssignmentTypeConstant? AssignmentType { get; set; }

    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    [JsonPropertyName("conditionVersion")]
    public string? ConditionVersion { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("createdOn")]
    public DateTime? CreatedOn { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("endDateTime")]
    public DateTime? EndDateTime { get; set; }

    [JsonPropertyName("expandedProperties")]
    public ExpandedPropertiesModel? ExpandedProperties { get; set; }

    [JsonPropertyName("linkedRoleEligibilityScheduleId")]
    public string? LinkedRoleEligibilityScheduleId { get; set; }

    [JsonPropertyName("linkedRoleEligibilityScheduleInstanceId")]
    public string? LinkedRoleEligibilityScheduleInstanceId { get; set; }

    [JsonPropertyName("memberType")]
    public MemberTypeConstant? MemberType { get; set; }

    [JsonPropertyName("originRoleAssignmentId")]
    public string? OriginRoleAssignmentId { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    [JsonPropertyName("principalType")]
    public PrincipalTypeConstant? PrincipalType { get; set; }

    [JsonPropertyName("roleAssignmentScheduleId")]
    public string? RoleAssignmentScheduleId { get; set; }

    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("startDateTime")]
    public DateTime? StartDateTime { get; set; }

    [JsonPropertyName("status")]
    public StatusConstant? Status { get; set; }
}
