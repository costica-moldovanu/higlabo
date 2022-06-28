﻿
namespace HigLabo.Net.Slack
{
    public class ChatUnfurlParameter : IRestApiParameter
    {
        public string ApiPath { get; private set; } = "chat.unfurl";
        public string HttpMethod { get; private set; } = "POST";
        public string Channel { get; set; } = "";
        public string Ts { get; set; } = "";
        public string Unfurls { get; set; } = "";
        public string Source { get; set; } = "";
        public string Unfurl_Id { get; set; } = "";
        public string User_Auth_Blocks { get; set; } = "";
        public string User_Auth_Message { get; set; } = "";
        public bool? User_Auth_Required { get; set; }
        public string User_Auth_Url { get; set; } = "";
    }
    public partial class ChatUnfurlResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        public async Task<ChatUnfurlResponse> ChatUnfurlAsync(string channel, string ts, string unfurls)
        {
            var p = new ChatUnfurlParameter();
            p.Channel = channel;
            p.Ts = ts;
            p.Unfurls = unfurls;
            return await this.SendAsync<ChatUnfurlParameter, ChatUnfurlResponse>(p, CancellationToken.None);
        }
        public async Task<ChatUnfurlResponse> ChatUnfurlAsync(string channel, string ts, string unfurls, CancellationToken cancellationToken)
        {
            var p = new ChatUnfurlParameter();
            p.Channel = channel;
            p.Ts = ts;
            p.Unfurls = unfurls;
            return await this.SendAsync<ChatUnfurlParameter, ChatUnfurlResponse>(p, cancellationToken);
        }
        public async Task<ChatUnfurlResponse> ChatUnfurlAsync(ChatUnfurlParameter parameter)
        {
            return await this.SendAsync<ChatUnfurlParameter, ChatUnfurlResponse>(parameter, CancellationToken.None);
        }
        public async Task<ChatUnfurlResponse> ChatUnfurlAsync(ChatUnfurlParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ChatUnfurlParameter, ChatUnfurlResponse>(parameter, cancellationToken);
        }
    }
}
