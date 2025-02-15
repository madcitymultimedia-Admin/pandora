using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DNS.v2018_05_01.RecordSets;

internal class ListByDnsZoneOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new DnsZoneId();

    public override Type NestedItemType() => typeof(RecordSetModel);

    public override Type? OptionsObject() => typeof(ListByDnsZoneOperation.ListByDnsZoneOptions);

    public override string? UriSuffix() => "/recordsets";

    internal class ListByDnsZoneOptions
    {
        [QueryStringName("$recordsetnamesuffix")]
        [Optional]
        public string Recordsetnamesuffix { get; set; }

        [QueryStringName("$top")]
        [Optional]
        public int Top { get; set; }
    }
}
