using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.VMware.v2023_03_01.WorkloadNetworks;


internal class WorkloadNetworkPortMirroringPropertiesModel
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("direction")]
    public PortMirroringDirectionEnumConstant? Direction { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("provisioningState")]
    public WorkloadNetworkPortMirroringProvisioningStateConstant? ProvisioningState { get; set; }

    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("status")]
    public PortMirroringStatusEnumConstant? Status { get; set; }
}
