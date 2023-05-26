﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/resources/openshiftchangerequest?view=graph-rest-1.0
    /// </summary>
    public partial class OpenShiftChangeRequest
    {
        public string? OpenShiftId { get; set; }
    }
}
