﻿
namespace HigLabo.Net.Slack
{
    public class AdminConversationsUnarchiveParameter : IRestApiParameter
    {
        public string ApiPath { get; private set; } = "admin.conversations.unarchive";
        public string HttpMethod { get; private set; } = "POST";
        public string Channel_Id { get; set; } = "";
    }
    public partial class AdminConversationsUnarchiveResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        public async Task<AdminConversationsUnarchiveResponse> AdminConversationsUnarchiveAsync(string channel_Id)
        {
            var p = new AdminConversationsUnarchiveParameter();
            p.Channel_Id = channel_Id;
            return await this.SendAsync<AdminConversationsUnarchiveParameter, AdminConversationsUnarchiveResponse>(p, CancellationToken.None);
        }
        public async Task<AdminConversationsUnarchiveResponse> AdminConversationsUnarchiveAsync(string channel_Id, CancellationToken cancellationToken)
        {
            var p = new AdminConversationsUnarchiveParameter();
            p.Channel_Id = channel_Id;
            return await this.SendAsync<AdminConversationsUnarchiveParameter, AdminConversationsUnarchiveResponse>(p, cancellationToken);
        }
        public async Task<AdminConversationsUnarchiveResponse> AdminConversationsUnarchiveAsync(AdminConversationsUnarchiveParameter parameter)
        {
            return await this.SendAsync<AdminConversationsUnarchiveParameter, AdminConversationsUnarchiveResponse>(parameter, CancellationToken.None);
        }
        public async Task<AdminConversationsUnarchiveResponse> AdminConversationsUnarchiveAsync(AdminConversationsUnarchiveParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<AdminConversationsUnarchiveParameter, AdminConversationsUnarchiveResponse>(parameter, cancellationToken);
        }
    }
}
