// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Directory.Beta.DirectoryCustomSecurityAttributeDefinitionAllowedValue;

internal class ListDirectoryCustomSecurityAttributeDefinitionByIdAllowedValuesOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new DirectoryCustomSecurityAttributeDefinitionId();
    public override Type NestedItemType() => typeof(AllowedValueCollectionResponseModel);
    public override string? UriSuffix() => "/allowedValues";
}
