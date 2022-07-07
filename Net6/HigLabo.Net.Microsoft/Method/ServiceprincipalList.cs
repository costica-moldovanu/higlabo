﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class ServiceprincipalListParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
        }
        public enum ApiPath
        {
            ServicePrincipals,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.ServicePrincipals: return $"/servicePrincipals";
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
    }
    public partial class ServiceprincipalListResponse : RestApiResponse
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/resources/serviceprincipal?view=graph-rest-1.0
        /// </summary>
        public partial class ServicePrincipal
        {
            public enum ServicePrincipalstring
            {
                Password,
                Saml,
                NotSupported,
                Oidc,
            }

            public bool? AccountEnabled { get; set; }
            public AddIn[]? AddIns { get; set; }
            public String[]? AlternativeNames { get; set; }
            public string? AppDescription { get; set; }
            public string? AppDisplayName { get; set; }
            public string? AppId { get; set; }
            public string? ApplicationTemplateId { get; set; }
            public Guid? AppOwnerOrganizationId { get; set; }
            public bool? AppRoleAssignmentRequired { get; set; }
            public AppRole[]? AppRoles { get; set; }
            public DateTimeOffset? DeletedDateTime { get; set; }
            public string? Description { get; set; }
            public string? DisabledByMicrosoftStatus { get; set; }
            public string? DisplayName { get; set; }
            public string? Homepage { get; set; }
            public string? Id { get; set; }
            public InformationalUrl? Info { get; set; }
            public KeyCredential[]? KeyCredentials { get; set; }
            public string? LoginUrl { get; set; }
            public string? LogoutUrl { get; set; }
            public string? Notes { get; set; }
            public String[]? NotificationEmailAddresses { get; set; }
            public PermissionScope[]? Oauth2PermissionScopes { get; set; }
            public PasswordCredential[]? PasswordCredentials { get; set; }
            public ServicePrincipalstring PreferredSingleSignOnMode { get; set; }
            public String[]? ReplyUrls { get; set; }
            public ResourceSpecificPermission[]? ResourceSpecificApplicationPermissions { get; set; }
            public SamlSingleSignOnSettings? SamlSingleSignOnSettings { get; set; }
            public String[]? ServicePrincipalNames { get; set; }
            public string? ServicePrincipalType { get; set; }
            public string? SignInAudience { get; set; }
            public String[]? Tags { get; set; }
            public string? TokenEncryptionKeyId { get; set; }
            public VerifiedPublisher? VerifiedPublisher { get; set; }
        }

        public ServicePrincipal[] Value { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-list?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalListResponse> ServiceprincipalListAsync()
        {
            var p = new ServiceprincipalListParameter();
            return await this.SendAsync<ServiceprincipalListParameter, ServiceprincipalListResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-list?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalListResponse> ServiceprincipalListAsync(CancellationToken cancellationToken)
        {
            var p = new ServiceprincipalListParameter();
            return await this.SendAsync<ServiceprincipalListParameter, ServiceprincipalListResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-list?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalListResponse> ServiceprincipalListAsync(ServiceprincipalListParameter parameter)
        {
            return await this.SendAsync<ServiceprincipalListParameter, ServiceprincipalListResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-list?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalListResponse> ServiceprincipalListAsync(ServiceprincipalListParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ServiceprincipalListParameter, ServiceprincipalListResponse>(parameter, cancellationToken);
        }
    }
}
