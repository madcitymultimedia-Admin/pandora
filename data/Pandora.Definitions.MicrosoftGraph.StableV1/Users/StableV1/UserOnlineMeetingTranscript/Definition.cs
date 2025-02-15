// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Users.StableV1.UserOnlineMeetingTranscript;

internal class Definition : ResourceDefinition
{
    public string Name => "UserOnlineMeetingTranscript";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateUserByIdOnlineMeetingByIdTranscriptOperation(),
        new DeleteUserByIdOnlineMeetingByIdTranscriptByIdOperation(),
        new GetUserByIdOnlineMeetingByIdTranscriptByIdOperation(),
        new GetUserByIdOnlineMeetingByIdTranscriptCountOperation(),
        new ListUserByIdOnlineMeetingByIdTranscriptsOperation(),
        new UpdateUserByIdOnlineMeetingByIdTranscriptByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
