using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2022_03_01.Jobs;


internal class UpdateDownloadProgressModel
{
    [JsonPropertyName("downloadPhase")]
    public DownloadPhaseConstant? DownloadPhase { get; set; }

    [JsonPropertyName("numberOfUpdatesDownloaded")]
    public int? NumberOfUpdatesDownloaded { get; set; }

    [JsonPropertyName("numberOfUpdatesToDownload")]
    public int? NumberOfUpdatesToDownload { get; set; }

    [JsonPropertyName("percentComplete")]
    public int? PercentComplete { get; set; }

    [JsonPropertyName("totalBytesDownloaded")]
    public float? TotalBytesDownloaded { get; set; }

    [JsonPropertyName("totalBytesToDownload")]
    public float? TotalBytesToDownload { get; set; }
}
