﻿
namespace HigLabo.Net.Slack
{
    public partial class UsersProfileGetParameter : IRestApiParameter
    {
        string IRestApiParameter.ApiPath { get; } = "users.profile.get";
        string IRestApiParameter.HttpMethod { get; } = "GET";
        public bool? Include_Labels { get; set; }
        public string User { get; set; }
    }
    public partial class UsersProfileGetResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        public async Task<UsersProfileGetResponse> UsersProfileGetAsync()
        {
            var p = new UsersProfileGetParameter();
            return await this.SendAsync<UsersProfileGetParameter, UsersProfileGetResponse>(p, CancellationToken.None);
        }
        public async Task<UsersProfileGetResponse> UsersProfileGetAsync(CancellationToken cancellationToken)
        {
            var p = new UsersProfileGetParameter();
            return await this.SendAsync<UsersProfileGetParameter, UsersProfileGetResponse>(p, cancellationToken);
        }
        public async Task<UsersProfileGetResponse> UsersProfileGetAsync(UsersProfileGetParameter parameter)
        {
            return await this.SendAsync<UsersProfileGetParameter, UsersProfileGetResponse>(parameter, CancellationToken.None);
        }
        public async Task<UsersProfileGetResponse> UsersProfileGetAsync(UsersProfileGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<UsersProfileGetParameter, UsersProfileGetResponse>(parameter, cancellationToken);
        }
    }
}
