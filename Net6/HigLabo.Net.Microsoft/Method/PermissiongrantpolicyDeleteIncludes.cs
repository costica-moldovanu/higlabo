﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class PermissiongrantPolicyDeleteIncludesParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string PermissiongrantpolicyId { get; set; }
            public string IncludeId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Policies_PermissionGrantPolicies_PermissiongrantpolicyId_Includes_IncludeId: return $"/policies/permissionGrantPolicies/{PermissiongrantpolicyId}/includes/{IncludeId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Policies_PermissionGrantPolicies_PermissiongrantpolicyId_Includes_IncludeId,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "DELETE";
    }
    public partial class PermissiongrantPolicyDeleteIncludesResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/permissiongrantpolicy-delete-includes?view=graph-rest-1.0
        /// </summary>
        public async Task<PermissiongrantPolicyDeleteIncludesResponse> PermissiongrantPolicyDeleteIncludesAsync()
        {
            var p = new PermissiongrantPolicyDeleteIncludesParameter();
            return await this.SendAsync<PermissiongrantPolicyDeleteIncludesParameter, PermissiongrantPolicyDeleteIncludesResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/permissiongrantpolicy-delete-includes?view=graph-rest-1.0
        /// </summary>
        public async Task<PermissiongrantPolicyDeleteIncludesResponse> PermissiongrantPolicyDeleteIncludesAsync(CancellationToken cancellationToken)
        {
            var p = new PermissiongrantPolicyDeleteIncludesParameter();
            return await this.SendAsync<PermissiongrantPolicyDeleteIncludesParameter, PermissiongrantPolicyDeleteIncludesResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/permissiongrantpolicy-delete-includes?view=graph-rest-1.0
        /// </summary>
        public async Task<PermissiongrantPolicyDeleteIncludesResponse> PermissiongrantPolicyDeleteIncludesAsync(PermissiongrantPolicyDeleteIncludesParameter parameter)
        {
            return await this.SendAsync<PermissiongrantPolicyDeleteIncludesParameter, PermissiongrantPolicyDeleteIncludesResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/permissiongrantpolicy-delete-includes?view=graph-rest-1.0
        /// </summary>
        public async Task<PermissiongrantPolicyDeleteIncludesResponse> PermissiongrantPolicyDeleteIncludesAsync(PermissiongrantPolicyDeleteIncludesParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<PermissiongrantPolicyDeleteIncludesParameter, PermissiongrantPolicyDeleteIncludesResponse>(parameter, cancellationToken);
        }
    }
}
