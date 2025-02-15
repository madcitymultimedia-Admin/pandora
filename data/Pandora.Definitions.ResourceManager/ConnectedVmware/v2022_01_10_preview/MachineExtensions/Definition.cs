using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ConnectedVmware.v2022_01_10_preview.MachineExtensions;

internal class Definition : ResourceDefinition
{
    public string Name => "MachineExtensions";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(StatusLevelTypesConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(MachineExtensionModel),
        typeof(MachineExtensionInstanceViewModel),
        typeof(MachineExtensionInstanceViewStatusModel),
        typeof(MachineExtensionPropertiesModel),
        typeof(MachineExtensionUpdateModel),
        typeof(MachineExtensionUpdatePropertiesModel),
    };
}
