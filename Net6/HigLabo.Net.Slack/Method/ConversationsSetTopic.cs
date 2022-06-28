﻿
namespace HigLabo.Net.Slack
{
    public class ConversationsSetTopicParameter : IRestApiParameter
    {
        public string ApiPath { get; private set; } = "conversations.setTopic";
        public string HttpMethod { get; private set; } = "POST";
        public string Channel { get; set; } = "";
        public string Topic { get; set; } = "";
    }
    public partial class ConversationsSetTopicResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        public async Task<ConversationsSetTopicResponse> ConversationsSetTopicAsync(string channel, string topic)
        {
            var p = new ConversationsSetTopicParameter();
            p.Channel = channel;
            p.Topic = topic;
            return await this.SendAsync<ConversationsSetTopicParameter, ConversationsSetTopicResponse>(p, CancellationToken.None);
        }
        public async Task<ConversationsSetTopicResponse> ConversationsSetTopicAsync(string channel, string topic, CancellationToken cancellationToken)
        {
            var p = new ConversationsSetTopicParameter();
            p.Channel = channel;
            p.Topic = topic;
            return await this.SendAsync<ConversationsSetTopicParameter, ConversationsSetTopicResponse>(p, cancellationToken);
        }
        public async Task<ConversationsSetTopicResponse> ConversationsSetTopicAsync(ConversationsSetTopicParameter parameter)
        {
            return await this.SendAsync<ConversationsSetTopicParameter, ConversationsSetTopicResponse>(parameter, CancellationToken.None);
        }
        public async Task<ConversationsSetTopicResponse> ConversationsSetTopicAsync(ConversationsSetTopicParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ConversationsSetTopicParameter, ConversationsSetTopicResponse>(parameter, cancellationToken);
        }
    }
}
