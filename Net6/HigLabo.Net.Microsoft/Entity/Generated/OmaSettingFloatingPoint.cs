﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/intune-deviceconfig-omasettingfloatingpoint?view=graph-rest-1.0
    /// </summary>
    public partial class OmaSettingFloatingPoint
    {
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string OmaUri { get; set; }
        public Single? Value { get; set; }
    }
}
