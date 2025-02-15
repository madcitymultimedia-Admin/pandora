using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PostgreSql.v2023_06_01_preview.VirtualEndpoints;


internal class VirtualEndpointResourceForPatchModel
{
    [JsonPropertyName("properties")]
    public VirtualEndpointResourcePropertiesModel? Properties { get; set; }
}
