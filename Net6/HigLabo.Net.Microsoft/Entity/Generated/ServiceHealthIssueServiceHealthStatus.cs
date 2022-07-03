﻿
namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/servicehealthissue?view=graph-rest-1.0
    /// </summary>
    public enum ServiceHealthIssueServiceHealthStatus
    {
        ServiceOperational,
        Investigating,
        RestoringService,
        VerifyingService,
        ServiceRestored,
        PostIncidentReviewPublished,
        ServiceDegradation,
        ServiceInterruption,
        ExtendedRecovery,
        FalsePositive,
        InvestigationSuspended,
        Resolved,
        MitigatedExternal,
        Mitigated,
        ResolvedExternal,
        Confirmed,
        Reported,
        UnknownFutureValue,
    }
}
