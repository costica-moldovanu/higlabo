﻿
namespace HigLabo.Net.Slack
{
    public class AdminAuthPolicyRemoveEntitiesParameter : IRestApiParameter
    {
        public string ApiPath { get; private set; } = "admin.auth.policy.removeEntities";
        public string HttpMethod { get; private set; } = "POST";
        public string Entity_Ids { get; set; } = "";
        public string Entity_Type { get; set; } = "";
        public string Policy_Name { get; set; } = "";
    }
    public partial class AdminAuthPolicyRemoveEntitiesResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        public async Task<AdminAuthPolicyRemoveEntitiesResponse> AdminAuthPolicyRemoveEntitiesAsync(string entity_Ids, string entity_Type, string policy_Name)
        {
            var p = new AdminAuthPolicyRemoveEntitiesParameter();
            p.Entity_Ids = entity_Ids;
            p.Entity_Type = entity_Type;
            p.Policy_Name = policy_Name;
            return await this.SendAsync<AdminAuthPolicyRemoveEntitiesParameter, AdminAuthPolicyRemoveEntitiesResponse>(p, CancellationToken.None);
        }
        public async Task<AdminAuthPolicyRemoveEntitiesResponse> AdminAuthPolicyRemoveEntitiesAsync(string entity_Ids, string entity_Type, string policy_Name, CancellationToken cancellationToken)
        {
            var p = new AdminAuthPolicyRemoveEntitiesParameter();
            p.Entity_Ids = entity_Ids;
            p.Entity_Type = entity_Type;
            p.Policy_Name = policy_Name;
            return await this.SendAsync<AdminAuthPolicyRemoveEntitiesParameter, AdminAuthPolicyRemoveEntitiesResponse>(p, cancellationToken);
        }
        public async Task<AdminAuthPolicyRemoveEntitiesResponse> AdminAuthPolicyRemoveEntitiesAsync(AdminAuthPolicyRemoveEntitiesParameter parameter)
        {
            return await this.SendAsync<AdminAuthPolicyRemoveEntitiesParameter, AdminAuthPolicyRemoveEntitiesResponse>(parameter, CancellationToken.None);
        }
        public async Task<AdminAuthPolicyRemoveEntitiesResponse> AdminAuthPolicyRemoveEntitiesAsync(AdminAuthPolicyRemoveEntitiesParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<AdminAuthPolicyRemoveEntitiesParameter, AdminAuthPolicyRemoveEntitiesResponse>(parameter, cancellationToken);
        }
    }
}
