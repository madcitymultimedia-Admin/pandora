using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2023_03_01.VirtualMachineScaleSets;

internal class DeallocateOperation : Pandora.Definitions.Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.Accepted,
                HttpStatusCode.OK,
        };

    public override bool LongRunning() => true;

    public override Type? RequestObject() => typeof(VirtualMachineScaleSetVMInstanceIDsModel);

    public override ResourceID? ResourceId() => new VirtualMachineScaleSetId();

    public override Type? OptionsObject() => typeof(DeallocateOperation.DeallocateOptions);

    public override string? UriSuffix() => "/deallocate";

    internal class DeallocateOptions
    {
        [QueryStringName("hibernate")]
        [Optional]
        public bool Hibernate { get; set; }
    }
}
