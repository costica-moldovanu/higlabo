﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class TeamGetMembersParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
            DisplayName,
            Description,
            Classification,
            Specialization,
            Visibility,
            FunSettings,
            GuestSettings,
            InternalId,
            IsArchived,
            MemberSettings,
            MessagingSettings,
            WebUrl,
            CreatedDateTime,
        }
        public enum ApiPath
        {
            Teams_TeamId_Members_MembershipId,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Teams_TeamId_Members_MembershipId: return $"/teams/{TeamId}/members/{MembershipId}";
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
        public string TeamId { get; set; }
        public string MembershipId { get; set; }
    }
    public partial class TeamGetMembersResponse : RestApiResponse
    {
        public string? Id { get; set; }
        public string? DisplayName { get; set; }
        public string[]? Roles { get; set; }
        public DateTimeOffset? VisibleHistoryStartDateTime { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-get-members?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamGetMembersResponse> TeamGetMembersAsync()
        {
            var p = new TeamGetMembersParameter();
            return await this.SendAsync<TeamGetMembersParameter, TeamGetMembersResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-get-members?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamGetMembersResponse> TeamGetMembersAsync(CancellationToken cancellationToken)
        {
            var p = new TeamGetMembersParameter();
            return await this.SendAsync<TeamGetMembersParameter, TeamGetMembersResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-get-members?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamGetMembersResponse> TeamGetMembersAsync(TeamGetMembersParameter parameter)
        {
            return await this.SendAsync<TeamGetMembersParameter, TeamGetMembersResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-get-members?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamGetMembersResponse> TeamGetMembersAsync(TeamGetMembersParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<TeamGetMembersParameter, TeamGetMembersResponse>(parameter, cancellationToken);
        }
    }
}
