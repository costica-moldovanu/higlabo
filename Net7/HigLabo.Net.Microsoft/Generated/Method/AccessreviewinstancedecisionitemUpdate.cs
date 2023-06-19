﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/accessreviewinstancedecisionitem-update?view=graph-rest-1.0
    /// </summary>
    public partial class AccessreviewinstancedecisionitemUpdateParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? AccessReviewScheduleDefinitionId { get; set; }
            public string? AccessReviewInstanceId { get; set; }
            public string? AccessReviewInstanceDecisionItemId { get; set; }
            public string? AccessReviewStageId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.IdentityGovernance_AccessReviews_Definitions_AccessReviewScheduleDefinitionId_Instances_AccessReviewInstanceId_Decisions_AccessReviewInstanceDecisionItemId: return $"/identityGovernance/accessReviews/definitions/{AccessReviewScheduleDefinitionId}/instances/{AccessReviewInstanceId}/decisions/{AccessReviewInstanceDecisionItemId}";
                    case ApiPath.IdentityGovernance_AccessReviews_Definitions_AccessReviewScheduleDefinitionId_Instances_AccessReviewInstanceId_Stages_AccessReviewStageId_Decisions_AccessReviewInstanceDecisionItemId: return $"/identityGovernance/accessReviews/definitions/{AccessReviewScheduleDefinitionId}/instances/{AccessReviewInstanceId}/stages/{AccessReviewStageId}/decisions/{AccessReviewInstanceDecisionItemId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            IdentityGovernance_AccessReviews_Definitions_AccessReviewScheduleDefinitionId_Instances_AccessReviewInstanceId_Decisions_AccessReviewInstanceDecisionItemId,
            IdentityGovernance_AccessReviews_Definitions_AccessReviewScheduleDefinitionId_Instances_AccessReviewInstanceId_Stages_AccessReviewStageId_Decisions_AccessReviewInstanceDecisionItemId,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "PATCH";
        public string? Decision { get; set; }
        public string? Justification { get; set; }
    }
    public partial class AccessreviewinstancedecisionitemUpdateResponse : RestApiResponse
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/accessreviewinstancedecisionitem-update?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/accessreviewinstancedecisionitem-update?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<AccessreviewinstancedecisionitemUpdateResponse> AccessreviewinstancedecisionitemUpdateAsync()
        {
            var p = new AccessreviewinstancedecisionitemUpdateParameter();
            return await this.SendAsync<AccessreviewinstancedecisionitemUpdateParameter, AccessreviewinstancedecisionitemUpdateResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/accessreviewinstancedecisionitem-update?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<AccessreviewinstancedecisionitemUpdateResponse> AccessreviewinstancedecisionitemUpdateAsync(CancellationToken cancellationToken)
        {
            var p = new AccessreviewinstancedecisionitemUpdateParameter();
            return await this.SendAsync<AccessreviewinstancedecisionitemUpdateParameter, AccessreviewinstancedecisionitemUpdateResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/accessreviewinstancedecisionitem-update?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<AccessreviewinstancedecisionitemUpdateResponse> AccessreviewinstancedecisionitemUpdateAsync(AccessreviewinstancedecisionitemUpdateParameter parameter)
        {
            return await this.SendAsync<AccessreviewinstancedecisionitemUpdateParameter, AccessreviewinstancedecisionitemUpdateResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/accessreviewinstancedecisionitem-update?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<AccessreviewinstancedecisionitemUpdateResponse> AccessreviewinstancedecisionitemUpdateAsync(AccessreviewinstancedecisionitemUpdateParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<AccessreviewinstancedecisionitemUpdateParameter, AccessreviewinstancedecisionitemUpdateResponse>(parameter, cancellationToken);
        }
    }
}
