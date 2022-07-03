﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/sharepointids?view=graph-rest-1.0
    /// </summary>
    public partial class SharePointIds
    {
        public String? ListId { get; set; }
        public String? ListItemId { get; set; }
        public String? ListItemUniqueId { get; set; }
        public String? SiteId { get; set; }
        public string SiteUrl { get; set; }
        public String? TenantId { get; set; }
        public String? WebId { get; set; }
    }
}
