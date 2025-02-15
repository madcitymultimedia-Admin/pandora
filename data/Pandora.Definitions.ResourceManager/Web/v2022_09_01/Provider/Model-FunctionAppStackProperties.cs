using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Web.v2022_09_01.Provider;


internal class FunctionAppStackPropertiesModel
{
    [JsonPropertyName("displayText")]
    public string? DisplayText { get; set; }

    [JsonPropertyName("majorVersions")]
    public List<FunctionAppMajorVersionModel>? MajorVersions { get; set; }

    [JsonPropertyName("preferredOs")]
    public StackPreferredOsConstant? PreferredOs { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
