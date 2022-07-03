﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/complianceinformation?view=graph-rest-1.0
    /// </summary>
    public partial class ComplianceInformation
    {
        public string CertificationName { get; set; }
        public CertificationControl[] CertificationControls { get; set; }
    }
}
