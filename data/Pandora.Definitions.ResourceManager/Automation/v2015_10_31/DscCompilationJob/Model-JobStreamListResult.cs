using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Automation.v2015_10_31.DscCompilationJob;


internal class JobStreamListResultModel
{
    [JsonPropertyName("nextLink")]
    public string? NextLink { get; set; }

    [JsonPropertyName("value")]
    public List<JobStreamModel>? Value { get; set; }
}
