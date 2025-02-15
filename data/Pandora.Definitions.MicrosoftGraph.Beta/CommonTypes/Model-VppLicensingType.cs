// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class VppLicensingTypeModel
{
    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("supportDeviceLicensing")]
    public bool? SupportDeviceLicensing { get; set; }

    [JsonPropertyName("supportUserLicensing")]
    public bool? SupportUserLicensing { get; set; }

    [JsonPropertyName("supportsDeviceLicensing")]
    public bool? SupportsDeviceLicensing { get; set; }

    [JsonPropertyName("supportsUserLicensing")]
    public bool? SupportsUserLicensing { get; set; }
}
