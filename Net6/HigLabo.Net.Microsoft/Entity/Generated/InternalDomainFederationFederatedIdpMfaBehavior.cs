﻿
namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/internaldomainfederation?view=graph-rest-1.0
    /// </summary>
    public enum InternalDomainFederationFederatedIdpMfaBehavior
    {
        AcceptIfMfaDoneByFederatedIdp,
        EnforceMfaByFederatedIdp,
        RejectMfaByFederatedIdp,
        UnknownFutureValue,
    }
}
