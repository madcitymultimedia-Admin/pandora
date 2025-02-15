using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Databricks.v2022_04_01_preview.Workspaces;


internal class ManagedDiskEncryptionModel
{
    [JsonPropertyName("keySource")]
    [Required]
    public EncryptionKeySourceConstant KeySource { get; set; }

    [JsonPropertyName("keyVaultProperties")]
    [Required]
    public ManagedDiskEncryptionKeyVaultPropertiesModel KeyVaultProperties { get; set; }

    [JsonPropertyName("rotationToLatestKeyVersionEnabled")]
    public bool? RotationToLatestKeyVersionEnabled { get; set; }
}
