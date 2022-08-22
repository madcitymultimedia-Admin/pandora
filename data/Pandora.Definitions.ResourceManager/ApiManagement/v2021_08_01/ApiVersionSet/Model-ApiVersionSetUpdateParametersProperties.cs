using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2021_08_01.ApiVersionSet;


internal class ApiVersionSetUpdateParametersPropertiesModel
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("versionHeaderName")]
    public string? VersionHeaderName { get; set; }

    [JsonPropertyName("versionQueryName")]
    public string? VersionQueryName { get; set; }

    [JsonPropertyName("versioningScheme")]
    public VersioningSchemeConstant? VersioningScheme { get; set; }
}
