﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/teammessagingsettings?view=graph-rest-1.0
    /// </summary>
    public partial class TeamMessagingSettings
    {
        public bool? AllowUserEditMessages { get; set; }
        public bool? AllowUserDeleteMessages { get; set; }
        public bool? AllowOwnerDeleteMessages { get; set; }
        public bool? AllowTeamMentions { get; set; }
        public bool? AllowChannelMentions { get; set; }
    }
}
