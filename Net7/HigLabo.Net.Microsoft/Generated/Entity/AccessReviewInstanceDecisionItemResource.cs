﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/resources/accessreviewinstancedecisionitemresource?view=graph-rest-1.0
    /// </summary>
    public partial class AccessReviewInstanceDecisionItemResource
    {
        public string? DisplayName { get; set; }
        public string? Id { get; set; }
        public string? Type { get; set; }
    }
}
