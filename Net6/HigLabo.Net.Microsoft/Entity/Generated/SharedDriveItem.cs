﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/shareddriveitem?view=graph-rest-1.0
    /// </summary>
    public partial class SharedDriveItem
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public IdentitySet? Owner { get; set; }
    }
}
