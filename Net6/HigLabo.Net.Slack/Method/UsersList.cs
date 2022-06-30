﻿
namespace HigLabo.Net.Slack
{
    public partial class UsersListParameter : IRestApiParameter, IRestApiPagingParameter
    {
        string IRestApiParameter.ApiPath { get; } = "users.list";
        string IRestApiParameter.HttpMethod { get; } = "GET";
        public string Cursor { get; set; }
        string IRestApiPagingParameter.NextPageToken { get; set; }
        public bool? Include_Locale { get; set; }
        public double? Limit { get; set; }
        public string Team_Id { get; set; }
    }
    public partial class UsersListResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        /// <summary>
        /// https://api.slack.com/methods/users.list
        /// </summary>
        public async Task<UsersListResponse> UsersListAsync()
        {
            var p = new UsersListParameter();
            return await this.SendAsync<UsersListParameter, UsersListResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://api.slack.com/methods/users.list
        /// </summary>
        public async Task<UsersListResponse> UsersListAsync(CancellationToken cancellationToken)
        {
            var p = new UsersListParameter();
            return await this.SendAsync<UsersListParameter, UsersListResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://api.slack.com/methods/users.list
        /// </summary>
        public async Task<UsersListResponse> UsersListAsync(UsersListParameter parameter)
        {
            return await this.SendAsync<UsersListParameter, UsersListResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://api.slack.com/methods/users.list
        /// </summary>
        public async Task<UsersListResponse> UsersListAsync(UsersListParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<UsersListParameter, UsersListResponse>(parameter, cancellationToken);
        }
        /// <summary>
        /// https://api.slack.com/methods/users.list
        /// </summary>
        public async Task<List<UsersListResponse>> UsersListAsync(PagingContext<UsersListResponse> context)
        {
            var p = new UsersListParameter();
            return await this.SendBatchAsync(p, context, CancellationToken.None);
        }
        /// <summary>
        /// https://api.slack.com/methods/users.list
        /// </summary>
        public async Task<List<UsersListResponse>> UsersListAsync(CancellationToken cancellationToken, PagingContext<UsersListResponse> context)
        {
            var p = new UsersListParameter();
            return await this.SendBatchAsync(p, context, cancellationToken);
        }
        /// <summary>
        /// https://api.slack.com/methods/users.list
        /// </summary>
        public async Task<List<UsersListResponse>> UsersListAsync(UsersListParameter parameter, PagingContext<UsersListResponse> context)
        {
            return await this.SendBatchAsync(parameter, context, CancellationToken.None);
        }
        /// <summary>
        /// https://api.slack.com/methods/users.list
        /// </summary>
        public async Task<List<UsersListResponse>> UsersListAsync(UsersListParameter parameter, PagingContext<UsersListResponse> context, CancellationToken cancellationToken)
        {
            return await this.SendBatchAsync(parameter, context, cancellationToken);
        }
    }
}
