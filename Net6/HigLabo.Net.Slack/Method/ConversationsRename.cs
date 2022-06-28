﻿
namespace HigLabo.Net.Slack
{
    public class ConversationsRenameParameter : IRestApiParameter
    {
        public string ApiPath { get; private set; } = "conversations.rename";
        public string HttpMethod { get; private set; } = "POST";
        public string Channel { get; set; } = "";
        public string Name { get; set; } = "";
    }
    public partial class ConversationsRenameResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        public async Task<ConversationsRenameResponse> ConversationsRenameAsync(string channel, string name)
        {
            var p = new ConversationsRenameParameter();
            p.Channel = channel;
            p.Name = name;
            return await this.SendAsync<ConversationsRenameParameter, ConversationsRenameResponse>(p, CancellationToken.None);
        }
        public async Task<ConversationsRenameResponse> ConversationsRenameAsync(string channel, string name, CancellationToken cancellationToken)
        {
            var p = new ConversationsRenameParameter();
            p.Channel = channel;
            p.Name = name;
            return await this.SendAsync<ConversationsRenameParameter, ConversationsRenameResponse>(p, cancellationToken);
        }
        public async Task<ConversationsRenameResponse> ConversationsRenameAsync(ConversationsRenameParameter parameter)
        {
            return await this.SendAsync<ConversationsRenameParameter, ConversationsRenameResponse>(parameter, CancellationToken.None);
        }
        public async Task<ConversationsRenameResponse> ConversationsRenameAsync(ConversationsRenameParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ConversationsRenameParameter, ConversationsRenameResponse>(parameter, cancellationToken);
        }
    }
}
