﻿
namespace HigLabo.Net.Slack
{
    public partial class ConversationsRenameParameter : IRestApiParameter
    {
        string IRestApiParameter.ApiPath { get; } = "conversations.rename";
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string Channel { get; set; }
        public string Name { get; set; }
    }
    public partial class ConversationsRenameResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        /// <summary>
        /// https://api.slack.com/methods/conversations.rename
        /// </summary>
        public async Task<ConversationsRenameResponse> ConversationsRenameAsync(string channel, string name)
        {
            var p = new ConversationsRenameParameter();
            p.Channel = channel;
            p.Name = name;
            return await this.SendAsync<ConversationsRenameParameter, ConversationsRenameResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://api.slack.com/methods/conversations.rename
        /// </summary>
        public async Task<ConversationsRenameResponse> ConversationsRenameAsync(string channel, string name, CancellationToken cancellationToken)
        {
            var p = new ConversationsRenameParameter();
            p.Channel = channel;
            p.Name = name;
            return await this.SendAsync<ConversationsRenameParameter, ConversationsRenameResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://api.slack.com/methods/conversations.rename
        /// </summary>
        public async Task<ConversationsRenameResponse> ConversationsRenameAsync(ConversationsRenameParameter parameter)
        {
            return await this.SendAsync<ConversationsRenameParameter, ConversationsRenameResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://api.slack.com/methods/conversations.rename
        /// </summary>
        public async Task<ConversationsRenameResponse> ConversationsRenameAsync(ConversationsRenameParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ConversationsRenameParameter, ConversationsRenameResponse>(parameter, cancellationToken);
        }
    }
}
