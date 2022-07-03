﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/intune-troubleshooting-devicemanagementtroubleshootingevent?view=graph-rest-1.0
    /// </summary>
    public partial class DeviceManagementTroubleshootingEvent
    {
        public string Id { get; set; }
        public DateTimeOffset EventDateTime { get; set; }
        public string CorrelationId { get; set; }
    }
}
