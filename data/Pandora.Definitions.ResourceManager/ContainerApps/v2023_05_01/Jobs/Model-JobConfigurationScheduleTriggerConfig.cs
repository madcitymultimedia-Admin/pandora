using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerApps.v2023_05_01.Jobs;


internal class JobConfigurationScheduleTriggerConfigModel
{
    [JsonPropertyName("cronExpression")]
    [Required]
    public string CronExpression { get; set; }

    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    [JsonPropertyName("replicaCompletionCount")]
    public int? ReplicaCompletionCount { get; set; }
}
