﻿
namespace HigLabo.Net.Slack
{
    public class AdminUsersSessionClearSettingsParameter : IRestApiParameter
    {
        public string ApiPath { get; private set; } = "admin.users.session.clearSettings";
        public string HttpMethod { get; private set; } = "POST";
        public string User_Ids { get; set; } = "";
    }
    public partial class AdminUsersSessionClearSettingsResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        public async Task<AdminUsersSessionClearSettingsResponse> AdminUsersSessionClearSettingsAsync(string user_Ids)
        {
            var p = new AdminUsersSessionClearSettingsParameter();
            p.User_Ids = user_Ids;
            return await this.SendAsync<AdminUsersSessionClearSettingsParameter, AdminUsersSessionClearSettingsResponse>(p, CancellationToken.None);
        }
        public async Task<AdminUsersSessionClearSettingsResponse> AdminUsersSessionClearSettingsAsync(string user_Ids, CancellationToken cancellationToken)
        {
            var p = new AdminUsersSessionClearSettingsParameter();
            p.User_Ids = user_Ids;
            return await this.SendAsync<AdminUsersSessionClearSettingsParameter, AdminUsersSessionClearSettingsResponse>(p, cancellationToken);
        }
        public async Task<AdminUsersSessionClearSettingsResponse> AdminUsersSessionClearSettingsAsync(AdminUsersSessionClearSettingsParameter parameter)
        {
            return await this.SendAsync<AdminUsersSessionClearSettingsParameter, AdminUsersSessionClearSettingsResponse>(parameter, CancellationToken.None);
        }
        public async Task<AdminUsersSessionClearSettingsResponse> AdminUsersSessionClearSettingsAsync(AdminUsersSessionClearSettingsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<AdminUsersSessionClearSettingsParameter, AdminUsersSessionClearSettingsResponse>(parameter, cancellationToken);
        }
    }
}
