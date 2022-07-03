﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/intune-remoteassistance-remoteassistancepartner?view=graph-rest-1.0
    /// </summary>
    public partial class RemoteAssistancePartner
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string OnboardingUrl { get; set; }
        public RemoteAssistancePartnerRemoteAssistanceOnboardingStatus OnboardingStatus { get; set; }
        public DateTimeOffset LastConnectionDateTime { get; set; }
    }
}
