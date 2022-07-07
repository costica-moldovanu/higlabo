﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class ChatDeleteTabsParameter : IRestApiParameter
    {
        public enum ApiPath
        {
            Chats_ChatId_Tabs_TabId,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Chats_ChatId_Tabs_TabId: return $"/chats/{ChatId}/tabs/{TabId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "DELETE";
        public string ChatId { get; set; }
        public string TabId { get; set; }
    }
    public partial class ChatDeleteTabsResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/chat-delete-tabs?view=graph-rest-1.0
        /// </summary>
        public async Task<ChatDeleteTabsResponse> ChatDeleteTabsAsync()
        {
            var p = new ChatDeleteTabsParameter();
            return await this.SendAsync<ChatDeleteTabsParameter, ChatDeleteTabsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/chat-delete-tabs?view=graph-rest-1.0
        /// </summary>
        public async Task<ChatDeleteTabsResponse> ChatDeleteTabsAsync(CancellationToken cancellationToken)
        {
            var p = new ChatDeleteTabsParameter();
            return await this.SendAsync<ChatDeleteTabsParameter, ChatDeleteTabsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/chat-delete-tabs?view=graph-rest-1.0
        /// </summary>
        public async Task<ChatDeleteTabsResponse> ChatDeleteTabsAsync(ChatDeleteTabsParameter parameter)
        {
            return await this.SendAsync<ChatDeleteTabsParameter, ChatDeleteTabsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/chat-delete-tabs?view=graph-rest-1.0
        /// </summary>
        public async Task<ChatDeleteTabsResponse> ChatDeleteTabsAsync(ChatDeleteTabsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ChatDeleteTabsParameter, ChatDeleteTabsResponse>(parameter, cancellationToken);
        }
    }
}
