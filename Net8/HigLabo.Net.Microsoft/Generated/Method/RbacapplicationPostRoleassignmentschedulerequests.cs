﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/rbacapplication-post-roleassignmentschedulerequests?view=graph-rest-1.0
    /// </summary>
    public partial class RbacapplicationPostRoleAssignmentschedulerequestsParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.RoleManagement_Directory_RoleAssignmentScheduleRequests: return $"/roleManagement/directory/roleAssignmentScheduleRequests";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum RbacapplicationPostRoleAssignmentschedulerequestsParameterUnifiedRoleScheduleRequestActions
        {
            AdminAssign,
            AdminUpdate,
            AdminRemove,
            SelfActivate,
            SelfDeactivate,
            AdminExtend,
            AdminRenew,
            SelfExtend,
            SelfRenew,
            UnknownFutureValue,
        }
        public enum ApiPath
        {
            RoleManagement_Directory_RoleAssignmentScheduleRequests,
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
        public RbacapplicationPostRoleAssignmentschedulerequestsParameterUnifiedRoleScheduleRequestActions Action { get; set; }
        public string? CustomData { get; set; }
        public string? PrincipalId { get; set; }
        public string? RoleDefinitionId { get; set; }
        public string? DirectoryScopeId { get; set; }
        public string? AppScopeId { get; set; }
        public string? Justification { get; set; }
        public RequestSchedule? ScheduleInfo { get; set; }
        public TicketInfo? TicketInfo { get; set; }
        public string? ApprovalId { get; set; }
        public DateTimeOffset? CompletedDateTime { get; set; }
        public IdentitySet? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? Id { get; set; }
        public bool? IsValidationOnly { get; set; }
        public string? Status { get; set; }
        public string? TargetScheduleId { get; set; }
        public UnifiedRoleEligibilitySchedule? ActivatedUsing { get; set; }
        public AppScope? AppScope { get; set; }
        public DirectoryObject? DirectoryScope { get; set; }
        public DirectoryObject? Principal { get; set; }
        public UnifiedRoleDefinition? RoleDefinition { get; set; }
        public UnifiedRoleAssignmentSchedule? TargetSchedule { get; set; }
    }
    public partial class RbacapplicationPostRoleAssignmentschedulerequestsResponse : RestApiResponse
    {
        public string? Action { get; set; }
        public string? ApprovalId { get; set; }
        public string? AppScopeId { get; set; }
        public DateTimeOffset? CompletedDateTime { get; set; }
        public IdentitySet? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? CustomData { get; set; }
        public string? DirectoryScopeId { get; set; }
        public string? Id { get; set; }
        public bool? IsValidationOnly { get; set; }
        public string? Justification { get; set; }
        public string? PrincipalId { get; set; }
        public string? RoleDefinitionId { get; set; }
        public RequestSchedule? ScheduleInfo { get; set; }
        public string? Status { get; set; }
        public string? TargetScheduleId { get; set; }
        public TicketInfo? TicketInfo { get; set; }
        public UnifiedRoleEligibilitySchedule? ActivatedUsing { get; set; }
        public AppScope? AppScope { get; set; }
        public DirectoryObject? DirectoryScope { get; set; }
        public DirectoryObject? Principal { get; set; }
        public UnifiedRoleDefinition? RoleDefinition { get; set; }
        public UnifiedRoleAssignmentSchedule? TargetSchedule { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/rbacapplication-post-roleassignmentschedulerequests?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/rbacapplication-post-roleassignmentschedulerequests?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<RbacapplicationPostRoleAssignmentschedulerequestsResponse> RbacapplicationPostRoleAssignmentschedulerequestsAsync()
        {
            var p = new RbacapplicationPostRoleAssignmentschedulerequestsParameter();
            return await this.SendAsync<RbacapplicationPostRoleAssignmentschedulerequestsParameter, RbacapplicationPostRoleAssignmentschedulerequestsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/rbacapplication-post-roleassignmentschedulerequests?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<RbacapplicationPostRoleAssignmentschedulerequestsResponse> RbacapplicationPostRoleAssignmentschedulerequestsAsync(CancellationToken cancellationToken)
        {
            var p = new RbacapplicationPostRoleAssignmentschedulerequestsParameter();
            return await this.SendAsync<RbacapplicationPostRoleAssignmentschedulerequestsParameter, RbacapplicationPostRoleAssignmentschedulerequestsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/rbacapplication-post-roleassignmentschedulerequests?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<RbacapplicationPostRoleAssignmentschedulerequestsResponse> RbacapplicationPostRoleAssignmentschedulerequestsAsync(RbacapplicationPostRoleAssignmentschedulerequestsParameter parameter)
        {
            return await this.SendAsync<RbacapplicationPostRoleAssignmentschedulerequestsParameter, RbacapplicationPostRoleAssignmentschedulerequestsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/rbacapplication-post-roleassignmentschedulerequests?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<RbacapplicationPostRoleAssignmentschedulerequestsResponse> RbacapplicationPostRoleAssignmentschedulerequestsAsync(RbacapplicationPostRoleAssignmentschedulerequestsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<RbacapplicationPostRoleAssignmentschedulerequestsParameter, RbacapplicationPostRoleAssignmentschedulerequestsResponse>(parameter, cancellationToken);
        }
    }
}
