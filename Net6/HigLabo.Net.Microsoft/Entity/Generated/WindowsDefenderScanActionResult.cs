﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/intune-devices-windowsdefenderscanactionresult?view=graph-rest-1.0
    /// </summary>
    public partial class WindowsDefenderScanActionResult
    {
        public enum WindowsDefenderScanActionResultActionState
        {
            None,
            Pending,
            Canceled,
            Active,
            Done,
            Failed,
            NotSupported,
        }

        public string ActionName { get; set; }
        public ActionState ActionState { get; set; }
        public DateTimeOffset StartDateTime { get; set; }
        public DateTimeOffset LastUpdatedDateTime { get; set; }
        public string ScanType { get; set; }
    }
}
