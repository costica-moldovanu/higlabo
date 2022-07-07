﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class TeamPostMembersParameter : IRestApiParameter
    {
        public enum ApiPath
        {
            Teams_TeamId_Members,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Teams_TeamId_Members: return $"/teams/{TeamId}/members";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string TeamId { get; set; }
    }
    public partial class TeamPostMembersResponse : RestApiResponse
    {
        public string? Id { get; set; }
        public string? DisplayName { get; set; }
        public string[]? Roles { get; set; }
        public DateTimeOffset? VisibleHistoryStartDateTime { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-post-members?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamPostMembersResponse> TeamPostMembersAsync()
        {
            var p = new TeamPostMembersParameter();
            return await this.SendAsync<TeamPostMembersParameter, TeamPostMembersResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-post-members?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamPostMembersResponse> TeamPostMembersAsync(CancellationToken cancellationToken)
        {
            var p = new TeamPostMembersParameter();
            return await this.SendAsync<TeamPostMembersParameter, TeamPostMembersResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-post-members?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamPostMembersResponse> TeamPostMembersAsync(TeamPostMembersParameter parameter)
        {
            return await this.SendAsync<TeamPostMembersParameter, TeamPostMembersResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-post-members?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamPostMembersResponse> TeamPostMembersAsync(TeamPostMembersParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<TeamPostMembersParameter, TeamPostMembersResponse>(parameter, cancellationToken);
        }
    }
}
