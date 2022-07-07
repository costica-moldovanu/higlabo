﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class UnifiedroledefinitionGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
        }
        public enum ApiPath
        {
            RoleManagement_Directory_RoleDefinitions_Id,
            RoleManagement_EntitlementManagement_RoleDefinitions_Id,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.RoleManagement_Directory_RoleDefinitions_Id: return $"/roleManagement/directory/roleDefinitions/{Id}";
                    case ApiPath.RoleManagement_EntitlementManagement_RoleDefinitions_Id: return $"/roleManagement/entitlementManagement/roleDefinitions/{Id}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "GET";
        public QueryParameter<Field> Query { get; set; } = new QueryParameter<Field>();
        IQueryParameter IQueryParameterProperty.Query
        {
            get
            {
                return this.Query;
            }
        }
        public string Id { get; set; }
    }
    public partial class UnifiedroledefinitionGetResponse : RestApiResponse
    {
        public string? Description { get; set; }
        public string? DisplayName { get; set; }
        public string? Id { get; set; }
        public bool? IsBuiltIn { get; set; }
        public bool? IsEnabled { get; set; }
        public String[]? ResourceScopes { get; set; }
        public UnifiedRolePermission[]? RolePermissions { get; set; }
        public string? TemplateId { get; set; }
        public string? Version { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/unifiedroledefinition-get?view=graph-rest-1.0
        /// </summary>
        public async Task<UnifiedroledefinitionGetResponse> UnifiedroledefinitionGetAsync()
        {
            var p = new UnifiedroledefinitionGetParameter();
            return await this.SendAsync<UnifiedroledefinitionGetParameter, UnifiedroledefinitionGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/unifiedroledefinition-get?view=graph-rest-1.0
        /// </summary>
        public async Task<UnifiedroledefinitionGetResponse> UnifiedroledefinitionGetAsync(CancellationToken cancellationToken)
        {
            var p = new UnifiedroledefinitionGetParameter();
            return await this.SendAsync<UnifiedroledefinitionGetParameter, UnifiedroledefinitionGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/unifiedroledefinition-get?view=graph-rest-1.0
        /// </summary>
        public async Task<UnifiedroledefinitionGetResponse> UnifiedroledefinitionGetAsync(UnifiedroledefinitionGetParameter parameter)
        {
            return await this.SendAsync<UnifiedroledefinitionGetParameter, UnifiedroledefinitionGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/unifiedroledefinition-get?view=graph-rest-1.0
        /// </summary>
        public async Task<UnifiedroledefinitionGetResponse> UnifiedroledefinitionGetAsync(UnifiedroledefinitionGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<UnifiedroledefinitionGetParameter, UnifiedroledefinitionGetResponse>(parameter, cancellationToken);
        }
    }
}
