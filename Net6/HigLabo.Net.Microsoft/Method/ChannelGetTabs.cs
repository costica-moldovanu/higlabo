﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class ChannelGetTabsParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string TeamId { get; set; }
            public string ChannelId { get; set; }
            public string TabId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Teams_TeamId_Channels_ChannelId_Tabs_TabId: return $"/teams/{TeamId}/channels/{ChannelId}/tabs/{TabId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
            Description,
            DisplayName,
            Id,
            IsFavoriteByDefault,
            Email,
            WebUrl,
            MembershipType,
            CreatedDateTime,
            Messages,
            Tabs,
            Members,
            FilesFolder,
            Operations,
        }
        public enum ApiPath
        {
            Teams_TeamId_Channels_ChannelId_Tabs_TabId,
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
    public partial class ChannelGetTabsResponse : RestApiResponse
    {
        public string? Id { get; set; }
        public string? DisplayName { get; set; }
        public string? WebUrl { get; set; }
        public TeamsTabConfiguration? Configuration { get; set; }
        public TeamsApp? TeamsApp { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/channel-get-tabs?view=graph-rest-1.0
        /// </summary>
        public async Task<ChannelGetTabsResponse> ChannelGetTabsAsync()
        {
            var p = new ChannelGetTabsParameter();
            return await this.SendAsync<ChannelGetTabsParameter, ChannelGetTabsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/channel-get-tabs?view=graph-rest-1.0
        /// </summary>
        public async Task<ChannelGetTabsResponse> ChannelGetTabsAsync(CancellationToken cancellationToken)
        {
            var p = new ChannelGetTabsParameter();
            return await this.SendAsync<ChannelGetTabsParameter, ChannelGetTabsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/channel-get-tabs?view=graph-rest-1.0
        /// </summary>
        public async Task<ChannelGetTabsResponse> ChannelGetTabsAsync(ChannelGetTabsParameter parameter)
        {
            return await this.SendAsync<ChannelGetTabsParameter, ChannelGetTabsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/channel-get-tabs?view=graph-rest-1.0
        /// </summary>
        public async Task<ChannelGetTabsResponse> ChannelGetTabsAsync(ChannelGetTabsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ChannelGetTabsParameter, ChannelGetTabsResponse>(parameter, cancellationToken);
        }
    }
}
