// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupOnenoteNotebookSectionPage;

internal class ListGroupByIdOnenoteNotebookByIdSectionByIdPagesOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new GroupIdOnenoteNotebookIdSectionId();
    public override Type NestedItemType() => typeof(OnenotePageCollectionResponseModel);
    public override string? UriSuffix() => "/pages";
}
