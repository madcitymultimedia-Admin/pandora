using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.NotificationHubs.v2017_04_01.Namespaces;

internal class Definition : ResourceDefinition
{
    public string Name => "Namespaces";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CheckAvailabilityOperation(),
        new CreateOrUpdateOperation(),
        new CreateOrUpdateAuthorizationRuleOperation(),
        new DeleteOperation(),
        new DeleteAuthorizationRuleOperation(),
        new GetOperation(),
        new GetAuthorizationRuleOperation(),
        new ListOperation(),
        new ListAllOperation(),
        new ListAuthorizationRulesOperation(),
        new ListKeysOperation(),
        new PatchOperation(),
        new RegenerateKeysOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(AccessRightsConstant),
        typeof(NamespaceTypeConstant),
        typeof(SkuNameConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(CheckAvailabilityParametersModel),
        typeof(CheckAvailabilityResultModel),
        typeof(NamespaceCreateOrUpdateParametersModel),
        typeof(NamespacePatchParametersModel),
        typeof(NamespacePropertiesModel),
        typeof(NamespaceResourceModel),
        typeof(PolicykeyResourceModel),
        typeof(ResourceListKeysModel),
        typeof(SharedAccessAuthorizationRuleCreateOrUpdateParametersModel),
        typeof(SharedAccessAuthorizationRulePropertiesModel),
        typeof(SharedAccessAuthorizationRuleResourceModel),
        typeof(SkuModel),
    };
}
