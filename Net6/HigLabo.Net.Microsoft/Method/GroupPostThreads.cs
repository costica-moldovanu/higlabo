﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class GroupPostThreadsParameter : IRestApiParameter
    {
        public enum ApiPath
        {
            Groups_Id_Threads,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Groups_Id_Threads: return $"/groups/{Id}/threads";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string Id { get; set; }
    }
    public partial class GroupPostThreadsResponse : RestApiResponse
    {
        public string? Id { get; set; }
        public Recipient[]? ToRecipients { get; set; }
        public Recipient[]? CcRecipients { get; set; }
        public string? Topic { get; set; }
        public bool? HasAttachments { get; set; }
        public DateTimeOffset? LastDeliveredDateTime { get; set; }
        public String[]? UniqueSenders { get; set; }
        public string? Preview { get; set; }
        public bool? IsLocked { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/group-post-threads?view=graph-rest-1.0
        /// </summary>
        public async Task<GroupPostThreadsResponse> GroupPostThreadsAsync()
        {
            var p = new GroupPostThreadsParameter();
            return await this.SendAsync<GroupPostThreadsParameter, GroupPostThreadsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/group-post-threads?view=graph-rest-1.0
        /// </summary>
        public async Task<GroupPostThreadsResponse> GroupPostThreadsAsync(CancellationToken cancellationToken)
        {
            var p = new GroupPostThreadsParameter();
            return await this.SendAsync<GroupPostThreadsParameter, GroupPostThreadsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/group-post-threads?view=graph-rest-1.0
        /// </summary>
        public async Task<GroupPostThreadsResponse> GroupPostThreadsAsync(GroupPostThreadsParameter parameter)
        {
            return await this.SendAsync<GroupPostThreadsParameter, GroupPostThreadsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/group-post-threads?view=graph-rest-1.0
        /// </summary>
        public async Task<GroupPostThreadsResponse> GroupPostThreadsAsync(GroupPostThreadsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<GroupPostThreadsParameter, GroupPostThreadsResponse>(parameter, cancellationToken);
        }
    }
}
