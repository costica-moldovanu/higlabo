﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/resources/externalconnectors-activitysettings?view=graph-rest-1.0
    /// </summary>
    public partial class ExternalConnectorsActivitySettings
    {
        public ExternalConnectorsUrltoitemresolverbase[]? UrlToItemResolvers { get; set; }
    }
}
