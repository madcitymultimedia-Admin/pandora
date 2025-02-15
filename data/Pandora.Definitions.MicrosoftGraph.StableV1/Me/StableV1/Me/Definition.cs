// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Me.StableV1.Me;

internal class Definition : ResourceDefinition
{
    public string Name => "Me";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new AssignMeLicenseOperation(),
        new CheckMeMemberGroupOperation(),
        new CheckMeMemberObjectOperation(),
        new CreateMeChangePasswordOperation(),
        new CreateMeExportPersonalDataOperation(),
        new CreateMeFindMeetingTimeOperation(),
        new CreateMeReprocessLicenseAssignmentOperation(),
        new CreateMeRetryServiceProvisioningOperation(),
        new CreateMeRevokeSignInSessionOperation(),
        new CreateMeSendMailOperation(),
        new CreateMeTranslateExchangeIdOperation(),
        new CreateMeWipeManagedAppRegistrationsByDeviceTagOperation(),
        new GetMeMailTipOperation(),
        new GetMeMemberGroupOperation(),
        new GetMeMemberObjectOperation(),
        new GetMeOperation(),
        new RemoveMeAllDevicesFromManagementOperation(),
        new RestoreMeOperation(),
        new UpdateMeOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(CreateMeTranslateExchangeIdRequestSourceIdTypeConstant),
        typeof(CreateMeTranslateExchangeIdRequestTargetIdTypeConstant),
        typeof(GetMeMailTipRequestMailTipsOptionsConstant)
    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AssignMeLicenseRequestModel),
        typeof(CheckMeMemberGroupRequestModel),
        typeof(CheckMeMemberObjectRequestModel),
        typeof(CreateMeChangePasswordRequestModel),
        typeof(CreateMeExportPersonalDataRequestModel),
        typeof(CreateMeFindMeetingTimeRequestModel),
        typeof(CreateMeSendMailRequestModel),
        typeof(CreateMeTranslateExchangeIdRequestModel),
        typeof(CreateMeWipeManagedAppRegistrationsByDeviceTagRequestModel),
        typeof(GetMeMailTipRequestModel),
        typeof(GetMeMemberGroupRequestModel),
        typeof(GetMeMemberObjectRequestModel)
    };
}
