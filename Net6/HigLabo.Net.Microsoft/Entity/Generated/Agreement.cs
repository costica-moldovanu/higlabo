﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/agreement?view=graph-rest-1.0
    /// </summary>
    public partial class Agreement
    {
        public string DisplayName { get; set; }
        public string Id { get; set; }
        public bool IsPerDeviceAcceptanceRequired { get; set; }
        public bool IsViewingBeforeAcceptanceRequired { get; set; }
        public TermsExpiration? TermsExpiration { get; set; }
        public string UserReacceptRequiredFrequency { get; set; }
    }
}
