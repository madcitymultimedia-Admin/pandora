using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MobileNetwork.v2023_09_01.Site;

internal class Definition : ResourceDefinition
{
    public string Name => "Site";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new DeletePacketCoreOperation(),
        new GetOperation(),
        new UpdateTagsOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ProvisioningStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(PacketCoreControlPlaneResourceIdModel),
        typeof(SiteModel),
        typeof(SiteDeletePacketCoreModel),
        typeof(SitePropertiesFormatModel),
        typeof(SubResourceModel),
        typeof(TagsObjectModel),
    };
}
