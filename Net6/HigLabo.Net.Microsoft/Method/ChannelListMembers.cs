﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class ChannelListMembersParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
        }
        public enum ApiPath
        {
            Teams_TeamId_Channels_ChannelId_Members,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Teams_TeamId_Channels_ChannelId_Members: return $"/teams/{TeamId}/channels/{ChannelId}/members";
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
        public string ChannelId { get; set; }
    }
    public partial class ChannelListMembersResponse : RestApiResponse
    {
        public string? Id { get; set; }
        public string? DisplayName { get; set; }
        public string[]? Roles { get; set; }
        public DateTimeOffset? VisibleHistoryStartDateTime { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/channel-list-members?view=graph-rest-1.0
        /// </summary>
        public async Task<ChannelListMembersResponse> ChannelListMembersAsync()
        {
            var p = new ChannelListMembersParameter();
            return await this.SendAsync<ChannelListMembersParameter, ChannelListMembersResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/channel-list-members?view=graph-rest-1.0
        /// </summary>
        public async Task<ChannelListMembersResponse> ChannelListMembersAsync(CancellationToken cancellationToken)
        {
            var p = new ChannelListMembersParameter();
            return await this.SendAsync<ChannelListMembersParameter, ChannelListMembersResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/channel-list-members?view=graph-rest-1.0
        /// </summary>
        public async Task<ChannelListMembersResponse> ChannelListMembersAsync(ChannelListMembersParameter parameter)
        {
            return await this.SendAsync<ChannelListMembersParameter, ChannelListMembersResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/channel-list-members?view=graph-rest-1.0
        /// </summary>
        public async Task<ChannelListMembersResponse> ChannelListMembersAsync(ChannelListMembersParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ChannelListMembersParameter, ChannelListMembersResponse>(parameter, cancellationToken);
        }
    }
}
