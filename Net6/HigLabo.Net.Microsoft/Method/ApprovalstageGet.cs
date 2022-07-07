﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class ApprovalstageGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
        }
        public enum ApiPath
        {
            IdentityGovernance_EntitlementManagement_AccessPackageAssignmentApprovals_AccessPackageAssignmentRequestId_Stages_ApprovalStageId,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.IdentityGovernance_EntitlementManagement_AccessPackageAssignmentApprovals_AccessPackageAssignmentRequestId_Stages_ApprovalStageId: return $"/identityGovernance/entitlementManagement/accessPackageAssignmentApprovals/{AccessPackageAssignmentRequestId}/stages/{ApprovalStageId}";
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
        public string AccessPackageAssignmentRequestId { get; set; }
        public string ApprovalStageId { get; set; }
    }
    public partial class ApprovalstageGetResponse : RestApiResponse
    {
        public bool? AssignedToMe { get; set; }
        public string? DisplayName { get; set; }
        public string? Id { get; set; }
        public string? Justification { get; set; }
        public string? ReviewResult { get; set; }
        public Identity? ReviewedBy { get; set; }
        public DateTimeOffset? ReviewedDateTime { get; set; }
        public string? Status { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/approvalstage-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ApprovalstageGetResponse> ApprovalstageGetAsync()
        {
            var p = new ApprovalstageGetParameter();
            return await this.SendAsync<ApprovalstageGetParameter, ApprovalstageGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/approvalstage-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ApprovalstageGetResponse> ApprovalstageGetAsync(CancellationToken cancellationToken)
        {
            var p = new ApprovalstageGetParameter();
            return await this.SendAsync<ApprovalstageGetParameter, ApprovalstageGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/approvalstage-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ApprovalstageGetResponse> ApprovalstageGetAsync(ApprovalstageGetParameter parameter)
        {
            return await this.SendAsync<ApprovalstageGetParameter, ApprovalstageGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/approvalstage-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ApprovalstageGetResponse> ApprovalstageGetAsync(ApprovalstageGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ApprovalstageGetParameter, ApprovalstageGetResponse>(parameter, cancellationToken);
        }
    }
}
