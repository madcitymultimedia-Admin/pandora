// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Users.StableV1.UserAuthenticationWindowsHelloForBusinessMethod;

internal class Definition : ResourceDefinition
{
    public string Name => "UserAuthenticationWindowsHelloForBusinessMethod";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new DeleteUserByIdAuthenticationWindowsHelloForBusinessMethodByIdOperation(),
        new GetUserByIdAuthenticationWindowsHelloForBusinessMethodByIdOperation(),
        new GetUserByIdAuthenticationWindowsHelloForBusinessMethodCountOperation(),
        new ListUserByIdAuthenticationWindowsHelloForBusinessMethodsOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
