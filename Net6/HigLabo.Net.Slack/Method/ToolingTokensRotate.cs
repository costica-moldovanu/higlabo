﻿
namespace HigLabo.Net.Slack
{
    public partial class ToolingTokensRotateParameter : IRestApiParameter
    {
        string IRestApiParameter.ApiPath { get; } = "tooling.tokens.rotate";
        string IRestApiParameter.HttpMethod { get; } = "GET";
        public string Refresh_Token { get; set; }
    }
    public partial class ToolingTokensRotateResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        public async Task<ToolingTokensRotateResponse> ToolingTokensRotateAsync(string refresh_Token)
        {
            var p = new ToolingTokensRotateParameter();
            p.Refresh_Token = refresh_Token;
            return await this.SendAsync<ToolingTokensRotateParameter, ToolingTokensRotateResponse>(p, CancellationToken.None);
        }
        public async Task<ToolingTokensRotateResponse> ToolingTokensRotateAsync(string refresh_Token, CancellationToken cancellationToken)
        {
            var p = new ToolingTokensRotateParameter();
            p.Refresh_Token = refresh_Token;
            return await this.SendAsync<ToolingTokensRotateParameter, ToolingTokensRotateResponse>(p, cancellationToken);
        }
        public async Task<ToolingTokensRotateResponse> ToolingTokensRotateAsync(ToolingTokensRotateParameter parameter)
        {
            return await this.SendAsync<ToolingTokensRotateParameter, ToolingTokensRotateResponse>(parameter, CancellationToken.None);
        }
        public async Task<ToolingTokensRotateResponse> ToolingTokensRotateAsync(ToolingTokensRotateParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ToolingTokensRotateParameter, ToolingTokensRotateResponse>(parameter, cancellationToken);
        }
    }
}
