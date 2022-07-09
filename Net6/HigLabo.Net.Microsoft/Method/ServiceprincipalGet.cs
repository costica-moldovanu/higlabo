﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class ServiceprincipalGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? Id { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.ServicePrincipals_Id: return $"/servicePrincipals/{Id}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            ServicePrincipals_Id,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
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
    public partial class ServiceprincipalGetResponse : RestApiResponse
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
        public AppRoleAssignment? AppRoleAssignedTo { get; set; }
        public AppRoleAssignment[]? AppRoleAssignments { get; set; }
        public ClaimsMappingPolicy[]? ClaimsMappingPolicies { get; set; }
        public DirectoryObject[]? CreatedObjects { get; set; }
        public HomeRealmDiscoveryPolicy[]? HomeRealmDiscoveryPolicies { get; set; }
        public DirectoryObject[]? MemberOf { get; set; }
        public OAuth2PermissionGrant[]? Oauth2PermissionGrants { get; set; }
        public DirectoryObject[]? OwnedObjects { get; set; }
        public DirectoryObject[]? Owners { get; set; }
        public TokenIssuancePolicy[]? TokenIssuancePolicies { get; set; }
        public TokenLifetimePolicy[]? TokenLifetimePolicies { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalGetResponse> ServiceprincipalGetAsync()
        {
            var p = new ServiceprincipalGetParameter();
            return await this.SendAsync<ServiceprincipalGetParameter, ServiceprincipalGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalGetResponse> ServiceprincipalGetAsync(CancellationToken cancellationToken)
        {
            var p = new ServiceprincipalGetParameter();
            return await this.SendAsync<ServiceprincipalGetParameter, ServiceprincipalGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalGetResponse> ServiceprincipalGetAsync(ServiceprincipalGetParameter parameter)
        {
            return await this.SendAsync<ServiceprincipalGetParameter, ServiceprincipalGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalGetResponse> ServiceprincipalGetAsync(ServiceprincipalGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ServiceprincipalGetParameter, ServiceprincipalGetResponse>(parameter, cancellationToken);
        }
    }
}
