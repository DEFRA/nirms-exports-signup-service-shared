using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Defra.Trade.ReMoS.AssuranceService.Shared.Enums;

public enum TradePartyApprovalStatus
{
    [Description("Not signed-up")]
    NotSignedUp,

    [Description("Approved for NIRMS")]
    Approved,

    [Description("Sign-up rejected")]
    Rejected,

    [Description("Sign-up started")]
    SignupStarted,

    [Description("Pending approval")]
    PendingApproval,

    [Description("Suspended")]
    Suspended
}
