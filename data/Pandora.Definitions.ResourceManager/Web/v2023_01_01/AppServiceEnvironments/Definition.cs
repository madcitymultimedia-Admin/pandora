using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Web.v2023_01_01.AppServiceEnvironments;

internal class Definition : ResourceDefinition
{
    public string Name => "AppServiceEnvironments";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ApproveOrRejectPrivateEndpointConnectionOperation(),
        new ChangeVnetOperation(),
        new CreateOrUpdateOperation(),
        new CreateOrUpdateMultiRolePoolOperation(),
        new CreateOrUpdateWorkerPoolOperation(),
        new DeleteOperation(),
        new DeleteAseCustomDnsSuffixConfigurationOperation(),
        new DeletePrivateEndpointConnectionOperation(),
        new GetOperation(),
        new GetAseCustomDnsSuffixConfigurationOperation(),
        new GetAseV3NetworkingConfigurationOperation(),
        new GetDiagnosticsItemOperation(),
        new GetInboundNetworkDependenciesEndpointsOperation(),
        new GetMultiRolePoolOperation(),
        new GetOutboundNetworkDependenciesEndpointsOperation(),
        new GetPrivateEndpointConnectionOperation(),
        new GetPrivateEndpointConnectionListOperation(),
        new GetPrivateLinkResourcesOperation(),
        new GetVipInfoOperation(),
        new GetWorkerPoolOperation(),
        new ListOperation(),
        new ListAppServicePlansOperation(),
        new ListByResourceGroupOperation(),
        new ListCapacitiesOperation(),
        new ListDiagnosticsOperation(),
        new ListMultiRoleMetricDefinitionsOperation(),
        new ListMultiRolePoolInstanceMetricDefinitionsOperation(),
        new ListMultiRolePoolSkusOperation(),
        new ListMultiRolePoolsOperation(),
        new ListMultiRoleUsagesOperation(),
        new ListOperationsOperation(),
        new ListUsagesOperation(),
        new ListWebAppsOperation(),
        new ListWebWorkerMetricDefinitionsOperation(),
        new ListWebWorkerUsagesOperation(),
        new ListWorkerPoolInstanceMetricDefinitionsOperation(),
        new ListWorkerPoolSkusOperation(),
        new ListWorkerPoolsOperation(),
        new RebootOperation(),
        new ResumeOperation(),
        new SuspendOperation(),
        new TestUpgradeAvailableNotificationOperation(),
        new UpdateOperation(),
        new UpdateAseCustomDnsSuffixConfigurationOperation(),
        new UpdateAseNetworkingConfigurationOperation(),
        new UpdateMultiRolePoolOperation(),
        new UpdateWorkerPoolOperation(),
        new UpgradeOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(AutoHealActionTypeConstant),
        typeof(AzureStorageStateConstant),
        typeof(AzureStorageTypeConstant),
        typeof(ClientCertModeConstant),
        typeof(ComputeModeOptionsConstant),
        typeof(ConnectionStringTypeConstant),
        typeof(CustomDnsSuffixProvisioningStateConstant),
        typeof(DaprLogLevelConstant),
        typeof(DefaultActionConstant),
        typeof(FtpsStateConstant),
        typeof(HostTypeConstant),
        typeof(HostingEnvironmentStatusConstant),
        typeof(IPFilterTagConstant),
        typeof(LoadBalancingModeConstant),
        typeof(ManagedPipelineModeConstant),
        typeof(OperationStatusConstant),
        typeof(ProvisioningStateConstant),
        typeof(RedundancyModeConstant),
        typeof(ScmTypeConstant),
        typeof(SiteAvailabilityStateConstant),
        typeof(SiteLoadBalancingConstant),
        typeof(SslStateConstant),
        typeof(StatusOptionsConstant),
        typeof(SupportedTlsVersionsConstant),
        typeof(TlsCipherSuitesConstant),
        typeof(UpgradeAvailabilityConstant),
        typeof(UpgradePreferenceConstant),
        typeof(UsageStateConstant),
        typeof(WorkerSizeOptionsConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AddressResponseModel),
        typeof(AddressResponsePropertiesModel),
        typeof(ApiDefinitionInfoModel),
        typeof(ApiManagementConfigModel),
        typeof(AppServiceEnvironmentModel),
        typeof(AppServiceEnvironmentPatchResourceModel),
        typeof(AppServiceEnvironmentResourceModel),
        typeof(AppServicePlanModel),
        typeof(AppServicePlanPropertiesModel),
        typeof(ArmIdWrapperModel),
        typeof(AseV3NetworkingConfigurationModel),
        typeof(AseV3NetworkingConfigurationPropertiesModel),
        typeof(AutoHealActionsModel),
        typeof(AutoHealCustomActionModel),
        typeof(AutoHealRulesModel),
        typeof(AutoHealTriggersModel),
        typeof(AzureStorageInfoValueModel),
        typeof(CapabilityModel),
        typeof(CloningInfoModel),
        typeof(ConnStringInfoModel),
        typeof(CorsSettingsModel),
        typeof(CsmUsageQuotaModel),
        typeof(CustomDnsSuffixConfigurationModel),
        typeof(CustomDnsSuffixConfigurationPropertiesModel),
        typeof(DaprConfigModel),
        typeof(EndpointDependencyModel),
        typeof(EndpointDetailModel),
        typeof(ErrorEntityModel),
        typeof(ExperimentsModel),
        typeof(ExtendedLocationModel),
        typeof(HandlerMappingModel),
        typeof(HostNameSslStateModel),
        typeof(HostingEnvironmentDiagnosticsModel),
        typeof(HostingEnvironmentProfileModel),
        typeof(IPSecurityRestrictionModel),
        typeof(InboundEnvironmentEndpointModel),
        typeof(KubeEnvironmentProfileModel),
        typeof(LocalizableStringModel),
        typeof(NameValuePairModel),
        typeof(OperationModel),
        typeof(OutboundEnvironmentEndpointModel),
        typeof(PrivateLinkConnectionStateModel),
        typeof(PrivateLinkResourceModel),
        typeof(PrivateLinkResourcePropertiesModel),
        typeof(PrivateLinkResourcesWrapperModel),
        typeof(PushSettingsModel),
        typeof(PushSettingsPropertiesModel),
        typeof(RampUpRuleModel),
        typeof(RemotePrivateEndpointConnectionARMResourceModel),
        typeof(RemotePrivateEndpointConnectionARMResourcePropertiesModel),
        typeof(RequestsBasedTriggerModel),
        typeof(ResourceConfigModel),
        typeof(ResourceMetricAvailabilityModel),
        typeof(ResourceMetricDefinitionModel),
        typeof(ResourceMetricDefinitionPropertiesModel),
        typeof(SiteModel),
        typeof(SiteConfigModel),
        typeof(SiteLimitsModel),
        typeof(SiteMachineKeyModel),
        typeof(SitePropertiesModel),
        typeof(SkuCapacityModel),
        typeof(SkuDescriptionModel),
        typeof(SkuInfoModel),
        typeof(SlotSwapStatusModel),
        typeof(SlowRequestsBasedTriggerModel),
        typeof(StampCapacityModel),
        typeof(StatusCodesBasedTriggerModel),
        typeof(StatusCodesRangeBasedTriggerModel),
        typeof(UsageModel),
        typeof(UsagePropertiesModel),
        typeof(VirtualApplicationModel),
        typeof(VirtualDirectoryModel),
        typeof(VirtualIPMappingModel),
        typeof(VirtualNetworkProfileModel),
        typeof(WorkerPoolModel),
        typeof(WorkerPoolResourceModel),
    };
}
