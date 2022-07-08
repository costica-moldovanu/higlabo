﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class TeamListMembersParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string TeamId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Teams_TeamId_Members: return $"/teams/{TeamId}/members";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Teams_TeamId_Members,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
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
    public partial class TeamListMembersResponse : RestApiResponse
    {
        public ConversationMember[] Value { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-list-members?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamListMembersResponse> TeamListMembersAsync()
        {
            var p = new TeamListMembersParameter();
            return await this.SendAsync<TeamListMembersParameter, TeamListMembersResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-list-members?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamListMembersResponse> TeamListMembersAsync(CancellationToken cancellationToken)
        {
            var p = new TeamListMembersParameter();
            return await this.SendAsync<TeamListMembersParameter, TeamListMembersResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-list-members?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamListMembersResponse> TeamListMembersAsync(TeamListMembersParameter parameter)
        {
            return await this.SendAsync<TeamListMembersParameter, TeamListMembersResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-list-members?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamListMembersResponse> TeamListMembersAsync(TeamListMembersParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<TeamListMembersParameter, TeamListMembersResponse>(parameter, cancellationToken);
        }
    }
}
