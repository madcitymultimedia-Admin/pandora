using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerApps.v2023_05_01.ContainerAppsSourceControls;


internal class GithubActionConfigurationModel
{
    [JsonPropertyName("azureCredentials")]
    public AzureCredentialsModel? AzureCredentials { get; set; }

    [JsonPropertyName("contextPath")]
    public string? ContextPath { get; set; }

    [JsonPropertyName("githubPersonalAccessToken")]
    public string? GitHubPersonalAccessToken { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("os")]
    public string? Os { get; set; }

    [JsonPropertyName("publishType")]
    public string? PublishType { get; set; }

    [JsonPropertyName("registryInfo")]
    public RegistryInfoModel? RegistryInfo { get; set; }

    [JsonPropertyName("runtimeStack")]
    public string? RuntimeStack { get; set; }

    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}
