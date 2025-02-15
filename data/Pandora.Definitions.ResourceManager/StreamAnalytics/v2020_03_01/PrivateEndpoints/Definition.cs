using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.StreamAnalytics.v2020_03_01.PrivateEndpoints;

internal class Definition : ResourceDefinition
{
    public string Name => "PrivateEndpoints";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListByClusterOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(PrivateEndpointModel),
        typeof(PrivateEndpointPropertiesModel),
        typeof(PrivateLinkConnectionStateModel),
        typeof(PrivateLinkServiceConnectionModel),
        typeof(PrivateLinkServiceConnectionPropertiesModel),
    };
}
