﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class AccessreviewsetPostDefinitionsParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.IdentityGovernance_AccessReviews_Definitions: return $"/identityGovernance/accessReviews/definitions";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            IdentityGovernance_AccessReviews_Definitions,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public AccessReviewNotificationRecipientItem[]? AdditionalNotificationRecipients { get; set; }
        public string? DescriptionForAdmins { get; set; }
        public string? DescriptionForReviewers { get; set; }
        public string? DisplayName { get; set; }
        public AccessReviewReviewerScope[]? FallbackReviewers { get; set; }
        public AccessReviewScope? InstanceEnumerationScope { get; set; }
        public AccessReviewReviewerScope[]? Reviewers { get; set; }
        public AccessReviewScope? Scope { get; set; }
        public AccessReviewScheduleSettings? Settings { get; set; }
        public UserIdentity? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? Id { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string? Status { get; set; }
        public AccessReviewInstance[]? Instances { get; set; }
    }
    public partial class AccessreviewsetPostDefinitionsResponse : RestApiResponse
    {
        public AccessReviewNotificationRecipientItem[]? AdditionalNotificationRecipients { get; set; }
        public UserIdentity? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? DescriptionForAdmins { get; set; }
        public string? DescriptionForReviewers { get; set; }
        public string? DisplayName { get; set; }
        public AccessReviewReviewerScope[]? FallbackReviewers { get; set; }
        public string? Id { get; set; }
        public AccessReviewScope? InstanceEnumerationScope { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public AccessReviewReviewerScope[]? Reviewers { get; set; }
        public AccessReviewScope? Scope { get; set; }
        public AccessReviewScheduleSettings? Settings { get; set; }
        public string? Status { get; set; }
        public AccessReviewInstance[]? Instances { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/accessreviewset-post-definitions?view=graph-rest-1.0
        /// </summary>
        public async Task<AccessreviewsetPostDefinitionsResponse> AccessreviewsetPostDefinitionsAsync()
        {
            var p = new AccessreviewsetPostDefinitionsParameter();
            return await this.SendAsync<AccessreviewsetPostDefinitionsParameter, AccessreviewsetPostDefinitionsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/accessreviewset-post-definitions?view=graph-rest-1.0
        /// </summary>
        public async Task<AccessreviewsetPostDefinitionsResponse> AccessreviewsetPostDefinitionsAsync(CancellationToken cancellationToken)
        {
            var p = new AccessreviewsetPostDefinitionsParameter();
            return await this.SendAsync<AccessreviewsetPostDefinitionsParameter, AccessreviewsetPostDefinitionsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/accessreviewset-post-definitions?view=graph-rest-1.0
        /// </summary>
        public async Task<AccessreviewsetPostDefinitionsResponse> AccessreviewsetPostDefinitionsAsync(AccessreviewsetPostDefinitionsParameter parameter)
        {
            return await this.SendAsync<AccessreviewsetPostDefinitionsParameter, AccessreviewsetPostDefinitionsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/accessreviewset-post-definitions?view=graph-rest-1.0
        /// </summary>
        public async Task<AccessreviewsetPostDefinitionsResponse> AccessreviewsetPostDefinitionsAsync(AccessreviewsetPostDefinitionsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<AccessreviewsetPostDefinitionsParameter, AccessreviewsetPostDefinitionsResponse>(parameter, cancellationToken);
        }
    }
}
