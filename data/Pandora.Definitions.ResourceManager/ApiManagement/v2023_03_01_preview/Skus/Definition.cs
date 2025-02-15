using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.Skus;

internal class Definition : ResourceDefinition
{
    public string Name => "Skus";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ApiManagementSkusListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ApiManagementSkuCapacityScaleTypeConstant),
        typeof(ApiManagementSkuRestrictionsReasonCodeConstant),
        typeof(ApiManagementSkuRestrictionsTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ApiManagementSkuModel),
        typeof(ApiManagementSkuCapabilitiesModel),
        typeof(ApiManagementSkuCapacityModel),
        typeof(ApiManagementSkuCostsModel),
        typeof(ApiManagementSkuLocationInfoModel),
        typeof(ApiManagementSkuRestrictionInfoModel),
        typeof(ApiManagementSkuRestrictionsModel),
        typeof(ApiManagementSkuZoneDetailsModel),
    };
}
