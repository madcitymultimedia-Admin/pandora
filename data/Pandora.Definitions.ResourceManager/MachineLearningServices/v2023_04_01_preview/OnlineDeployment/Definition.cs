using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01_preview.OnlineDeployment;

internal class Definition : ResourceDefinition
{
    public string Name => "OnlineDeployment";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new GetLogsOperation(),
        new ListOperation(),
        new ListSkusOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ContainerTypeConstant),
        typeof(DataCollectionModeConstant),
        typeof(DeploymentProvisioningStateConstant),
        typeof(EgressPublicNetworkAccessTypeConstant),
        typeof(EndpointComputeTypeConstant),
        typeof(RollingRateTypeConstant),
        typeof(ScaleTypeConstant),
        typeof(SkuScaleTypeConstant),
        typeof(SkuTierConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(CodeConfigurationModel),
        typeof(CollectionModel),
        typeof(ContainerResourceRequirementsModel),
        typeof(ContainerResourceSettingsModel),
        typeof(DataCollectorModel),
        typeof(DefaultScaleSettingsModel),
        typeof(DeploymentLogsModel),
        typeof(DeploymentLogsRequestModel),
        typeof(KubernetesOnlineDeploymentModel),
        typeof(ManagedOnlineDeploymentModel),
        typeof(OnlineDeploymentModel),
        typeof(OnlineDeploymentTrackedResourceModel),
        typeof(OnlineRequestSettingsModel),
        typeof(OnlineScaleSettingsModel),
        typeof(PartialMinimalTrackedResourceWithSkuModel),
        typeof(PartialSkuModel),
        typeof(ProbeSettingsModel),
        typeof(RequestLoggingModel),
        typeof(SkuModel),
        typeof(SkuCapacityModel),
        typeof(SkuResourceModel),
        typeof(SkuSettingModel),
        typeof(TargetUtilizationScaleSettingsModel),
    };
}
