﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class AccessreviewhistorydefinitionGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
        }
        public enum ApiPath
        {
            IdentityGovernance_AccessReviews_HistoryDefinitions_DefinitionId,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.IdentityGovernance_AccessReviews_HistoryDefinitions_DefinitionId: return $"/identityGovernance/accessReviews/historyDefinitions/{DefinitionId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "GET";
        public QueryParameter<Field> Query { get; set; } = new QueryParameter<Field>();
        IQueryParameter IQueryParameterProperty.Query
        {
            get
            {
                return this.Query;
            }
        }
        public string DefinitionId { get; set; }
    }
    public partial class AccessreviewhistorydefinitionGetResponse : RestApiResponse
    {
        public enum AccessReviewHistoryDefinitionString
        {
            Approve,
            Deny,
            DontKnow,
            NotReviewed,
            NotNotified,
        }
        public enum AccessReviewHistoryDefinitionAccessReviewHistoryStatus
        {
            Done,
            InProgress,
            Error,
            Requested,
            UnknownFutureValue,
        }

        public UserIdentity? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public AccessReviewHistoryDefinitionString Decisions { get; set; }
        public string? DisplayName { get; set; }
        public string? Id { get; set; }
        public DateTimeOffset? ReviewHistoryPeriodEndDateTime { get; set; }
        public DateTimeOffset? ReviewHistoryPeriodStartDateTime { get; set; }
        public AccessReviewHistoryScheduleSettings? ScheduleSettings { get; set; }
        public AccessReviewScope[]? Scopes { get; set; }
        public AccessReviewHistoryDefinitionAccessReviewHistoryStatus Status { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/accessreviewhistorydefinition-get?view=graph-rest-1.0
        /// </summary>
        public async Task<AccessreviewhistorydefinitionGetResponse> AccessreviewhistorydefinitionGetAsync()
        {
            var p = new AccessreviewhistorydefinitionGetParameter();
            return await this.SendAsync<AccessreviewhistorydefinitionGetParameter, AccessreviewhistorydefinitionGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/accessreviewhistorydefinition-get?view=graph-rest-1.0
        /// </summary>
        public async Task<AccessreviewhistorydefinitionGetResponse> AccessreviewhistorydefinitionGetAsync(CancellationToken cancellationToken)
        {
            var p = new AccessreviewhistorydefinitionGetParameter();
            return await this.SendAsync<AccessreviewhistorydefinitionGetParameter, AccessreviewhistorydefinitionGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/accessreviewhistorydefinition-get?view=graph-rest-1.0
        /// </summary>
        public async Task<AccessreviewhistorydefinitionGetResponse> AccessreviewhistorydefinitionGetAsync(AccessreviewhistorydefinitionGetParameter parameter)
        {
            return await this.SendAsync<AccessreviewhistorydefinitionGetParameter, AccessreviewhistorydefinitionGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/accessreviewhistorydefinition-get?view=graph-rest-1.0
        /// </summary>
        public async Task<AccessreviewhistorydefinitionGetResponse> AccessreviewhistorydefinitionGetAsync(AccessreviewhistorydefinitionGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<AccessreviewhistorydefinitionGetParameter, AccessreviewhistorydefinitionGetResponse>(parameter, cancellationToken);
        }
    }
}
