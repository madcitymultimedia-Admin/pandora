// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Users.StableV1.UserMessage;

internal class Definition : ResourceDefinition
{
    public string Name => "UserMessage";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateUpdateUserByIdMessageByIdValueOperation(),
        new CreateUserByIdMessageByIdCopyOperation(),
        new CreateUserByIdMessageByIdCreateForwardOperation(),
        new CreateUserByIdMessageByIdCreateReplyAllOperation(),
        new CreateUserByIdMessageByIdCreateReplyOperation(),
        new CreateUserByIdMessageByIdForwardOperation(),
        new CreateUserByIdMessageByIdMoveOperation(),
        new CreateUserByIdMessageByIdReplyAllOperation(),
        new CreateUserByIdMessageByIdReplyOperation(),
        new CreateUserByIdMessageByIdSendOperation(),
        new CreateUserByIdMessageOperation(),
        new DeleteUserByIdMessageByIdOperation(),
        new GetUserByIdMessageByIdOperation(),
        new GetUserByIdMessageByIdValueOperation(),
        new GetUserByIdMessageCountOperation(),
        new ListUserByIdMessagesOperation(),
        new UpdateUserByIdMessageByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(CreateUserByIdMessageByIdCopyRequestModel),
        typeof(CreateUserByIdMessageByIdCreateForwardRequestModel),
        typeof(CreateUserByIdMessageByIdCreateReplyAllRequestModel),
        typeof(CreateUserByIdMessageByIdCreateReplyRequestModel),
        typeof(CreateUserByIdMessageByIdForwardRequestModel),
        typeof(CreateUserByIdMessageByIdMoveRequestModel),
        typeof(CreateUserByIdMessageByIdReplyAllRequestModel),
        typeof(CreateUserByIdMessageByIdReplyRequestModel)
    };
}
