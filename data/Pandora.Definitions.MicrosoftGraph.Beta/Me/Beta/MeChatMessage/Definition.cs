// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeChatMessage;

internal class Definition : ResourceDefinition
{
    public string Name => "MeChatMessage";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateMeChatByIdMessageByIdSoftDeleteOperation(),
        new CreateMeChatByIdMessageByIdUndoSoftDeleteOperation(),
        new CreateMeChatByIdMessageOperation(),
        new DeleteMeChatByIdMessageByIdOperation(),
        new GetMeChatByIdMessageByIdOperation(),
        new GetMeChatByIdMessageCountOperation(),
        new ListMeChatByIdMessagesOperation(),
        new SetMeChatByIdMessageByIdReactionOperation(),
        new UnsetMeChatByIdMessageByIdReactionOperation(),
        new UpdateMeChatByIdMessageByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(SetMeChatByIdMessageByIdReactionRequestModel),
        typeof(UnsetMeChatByIdMessageByIdReactionRequestModel)
    };
}
