﻿
namespace HigLabo.Net.Slack
{
    public partial class AuthRevokeParameter : IRestApiParameter
    {
        string IRestApiParameter.ApiPath { get; } = "auth.revoke";
        string IRestApiParameter.HttpMethod { get; } = "GET";
        public bool? Test { get; set; }
    }
    public partial class AuthRevokeResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        public async Task<AuthRevokeResponse> AuthRevokeAsync()
        {
            var p = new AuthRevokeParameter();
            return await this.SendAsync<AuthRevokeParameter, AuthRevokeResponse>(p, CancellationToken.None);
        }
        public async Task<AuthRevokeResponse> AuthRevokeAsync(CancellationToken cancellationToken)
        {
            var p = new AuthRevokeParameter();
            return await this.SendAsync<AuthRevokeParameter, AuthRevokeResponse>(p, cancellationToken);
        }
        public async Task<AuthRevokeResponse> AuthRevokeAsync(AuthRevokeParameter parameter)
        {
            return await this.SendAsync<AuthRevokeParameter, AuthRevokeResponse>(parameter, CancellationToken.None);
        }
        public async Task<AuthRevokeResponse> AuthRevokeAsync(AuthRevokeParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<AuthRevokeParameter, AuthRevokeResponse>(parameter, cancellationToken);
        }
    }
}
