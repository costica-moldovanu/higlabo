﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/intune-apps-iosmobileappconfiguration?view=graph-rest-1.0
    /// </summary>
    public partial class IosMobileAppConfiguration
    {
        public string Id { get; set; }
        public String[] TargetedMobileApps { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public string Description { get; set; }
        public DateTimeOffset LastModifiedDateTime { get; set; }
        public string DisplayName { get; set; }
        public Int32? Version { get; set; }
        public string EncodedSettingXml { get; set; }
        public AppConfigurationSettingItem[] Settings { get; set; }
    }
}
