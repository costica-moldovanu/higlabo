﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/intune-apps-androidlobapp?view=graph-rest-1.0
    /// </summary>
    public partial class AndroidLobApp
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public MimeContent? LargeIcon { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public DateTimeOffset LastModifiedDateTime { get; set; }
        public bool IsFeatured { get; set; }
        public string PrivacyInformationUrl { get; set; }
        public string InformationUrl { get; set; }
        public string Owner { get; set; }
        public string Developer { get; set; }
        public string Notes { get; set; }
        public AndroidLobAppMobileAppPublishingState PublishingState { get; set; }
        public string CommittedContentVersion { get; set; }
        public string FileName { get; set; }
        public Int64? Size { get; set; }
        public string PackageId { get; set; }
        public AndroidMinimumOperatingSystem? MinimumSupportedOperatingSystem { get; set; }
        public string VersionName { get; set; }
        public string VersionCode { get; set; }
    }
}
