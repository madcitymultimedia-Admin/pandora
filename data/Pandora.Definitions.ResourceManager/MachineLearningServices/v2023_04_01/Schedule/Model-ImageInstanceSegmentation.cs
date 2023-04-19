using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01.Schedule;

[ValueForType("ImageInstanceSegmentation")]
internal class ImageInstanceSegmentationModel : AutoMLVerticalModel
{
    [JsonPropertyName("limitSettings")]
    public ImageLimitSettingsModel? LimitSettings { get; set; }

    [JsonPropertyName("modelSettings")]
    public ImageModelSettingsObjectDetectionModel? ModelSettings { get; set; }

    [JsonPropertyName("primaryMetric")]
    public InstanceSegmentationPrimaryMetricsConstant? PrimaryMetric { get; set; }

    [JsonPropertyName("searchSpace")]
    public List<ImageModelDistributionSettingsObjectDetectionModel>? SearchSpace { get; set; }

    [JsonPropertyName("sweepSettings")]
    public ImageSweepSettingsModel? SweepSettings { get; set; }

    [JsonPropertyName("validationData")]
    public JobInputModel? ValidationData { get; set; }

    [JsonPropertyName("validationDataSize")]
    public float? ValidationDataSize { get; set; }
}
