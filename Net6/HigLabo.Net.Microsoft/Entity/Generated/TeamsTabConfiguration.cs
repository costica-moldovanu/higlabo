﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/teamstabconfiguration?view=graph-rest-1.0
    /// </summary>
    public partial class TeamsTabConfiguration
    {
        public string? EntityId { get; set; }
        public string? ContentUrl { get; set; }
        public string? RemoveUrl { get; set; }
        public string? WebsiteUrl { get; set; }
    }
}
