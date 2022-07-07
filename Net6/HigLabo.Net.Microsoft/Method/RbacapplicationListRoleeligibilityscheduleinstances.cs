﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class RbacapplicationListRoleeligibilityscheduleinstancesParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
        }
        public enum ApiPath
        {
            RoleManagement_Directory_RoleEligibilityScheduleInstances,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.RoleManagement_Directory_RoleEligibilityScheduleInstances: return $"/roleManagement/directory/roleEligibilityScheduleInstances";
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
    }
    public partial class RbacapplicationListRoleeligibilityscheduleinstancesResponse : RestApiResponse
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/resources/unifiedroleeligibilityscheduleinstance?view=graph-rest-1.0
        /// </summary>
        public partial class UnifiedRoleEligibilityScheduleInstance
        {
            public string? AppScopeId { get; set; }
            public string? DirectoryScopeId { get; set; }
            public DateTimeOffset? EndDateTime { get; set; }
            public string? Id { get; set; }
            public string? MemberType { get; set; }
            public string? PrincipalId { get; set; }
            public string? RoleDefinitionId { get; set; }
            public string? RoleEligibilityScheduleId { get; set; }
            public DateTimeOffset? StartDateTime { get; set; }
        }

        public UnifiedRoleEligibilityScheduleInstance[] Value { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/rbacapplication-list-roleeligibilityscheduleinstances?view=graph-rest-1.0
        /// </summary>
        public async Task<RbacapplicationListRoleeligibilityscheduleinstancesResponse> RbacapplicationListRoleeligibilityscheduleinstancesAsync()
        {
            var p = new RbacapplicationListRoleeligibilityscheduleinstancesParameter();
            return await this.SendAsync<RbacapplicationListRoleeligibilityscheduleinstancesParameter, RbacapplicationListRoleeligibilityscheduleinstancesResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/rbacapplication-list-roleeligibilityscheduleinstances?view=graph-rest-1.0
        /// </summary>
        public async Task<RbacapplicationListRoleeligibilityscheduleinstancesResponse> RbacapplicationListRoleeligibilityscheduleinstancesAsync(CancellationToken cancellationToken)
        {
            var p = new RbacapplicationListRoleeligibilityscheduleinstancesParameter();
            return await this.SendAsync<RbacapplicationListRoleeligibilityscheduleinstancesParameter, RbacapplicationListRoleeligibilityscheduleinstancesResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/rbacapplication-list-roleeligibilityscheduleinstances?view=graph-rest-1.0
        /// </summary>
        public async Task<RbacapplicationListRoleeligibilityscheduleinstancesResponse> RbacapplicationListRoleeligibilityscheduleinstancesAsync(RbacapplicationListRoleeligibilityscheduleinstancesParameter parameter)
        {
            return await this.SendAsync<RbacapplicationListRoleeligibilityscheduleinstancesParameter, RbacapplicationListRoleeligibilityscheduleinstancesResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/rbacapplication-list-roleeligibilityscheduleinstances?view=graph-rest-1.0
        /// </summary>
        public async Task<RbacapplicationListRoleeligibilityscheduleinstancesResponse> RbacapplicationListRoleeligibilityscheduleinstancesAsync(RbacapplicationListRoleeligibilityscheduleinstancesParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<RbacapplicationListRoleeligibilityscheduleinstancesParameter, RbacapplicationListRoleeligibilityscheduleinstancesResponse>(parameter, cancellationToken);
        }
    }
}
