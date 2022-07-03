﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/intune-apps-mobileappassignment?view=graph-rest-1.0
    /// </summary>
    public partial class MobileAppAssignment
    {
        public string Id { get; set; }
        public MobileAppAssignmentInstallIntent Intent { get; set; }
        public DeviceAndAppManagementAssignmentTarget? Target { get; set; }
        public MobileAppAssignmentSettings? Settings { get; set; }
    }
}
