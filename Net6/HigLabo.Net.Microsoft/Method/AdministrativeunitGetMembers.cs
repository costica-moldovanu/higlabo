﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class AdministrativeunitGetMembersParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
        }
        public enum ApiPath
        {
            Directory_AdministrativeUnits_Id_Members_Id,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Directory_AdministrativeUnits_Id_Members_Id: return $"/directory/administrativeUnits/{AdministrativeUnitsId}/members/{MembersId}";
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
        public string AdministrativeUnitsId { get; set; }
        public string MembersId { get; set; }
    }
    public partial class AdministrativeunitGetMembersResponse : RestApiResponse
    {
        public enum UserAgeGroup
        {
            Null,
            Minor,
            NotAdult,
            Adult,
        }
        public enum UserConsentProvidedForMinor
        {
            Null,
            Granted,
            Denied,
            NotRequired,
        }
        public enum UserLegalAgeGroupClassification
        {
            Null,
            MinorWithOutParentalConsent,
            MinorWithParentalConsent,
            MinorNoParentalConsentRequired,
            NotAdult,
            Adult,
        }

        public string? AboutMe { get; set; }
        public bool? AccountEnabled { get; set; }
        public UserAgeGroup AgeGroup { get; set; }
        public AssignedLicense[]? AssignedLicenses { get; set; }
        public AssignedPlan[]? AssignedPlans { get; set; }
        public DateTimeOffset? Birthday { get; set; }
        public String[]? BusinessPhones { get; set; }
        public string? City { get; set; }
        public string? CompanyName { get; set; }
        public UserConsentProvidedForMinor ConsentProvidedForMinor { get; set; }
        public string? Country { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? CreationType { get; set; }
        public DateTimeOffset? DeletedDateTime { get; set; }
        public string? Department { get; set; }
        public string? DisplayName { get; set; }
        public DateTimeOffset? EmployeeHireDate { get; set; }
        public string? EmployeeId { get; set; }
        public EmployeeOrgData? EmployeeOrgData { get; set; }
        public string? EmployeeType { get; set; }
        public string? ExternalUserState { get; set; }
        public DateTimeOffset? ExternalUserStateChangeDateTime { get; set; }
        public string? FaxNumber { get; set; }
        public string? GivenName { get; set; }
        public DateTimeOffset? HireDate { get; set; }
        public string? Id { get; set; }
        public ObjectIdentity[]? Identities { get; set; }
        public String[]? ImAddresses { get; set; }
        public String[]? Interests { get; set; }
        public bool? IsResourceAccount { get; set; }
        public string? JobTitle { get; set; }
        public DateTimeOffset? LastPasswordChangeDateTime { get; set; }
        public UserLegalAgeGroupClassification LegalAgeGroupClassification { get; set; }
        public LicenseAssignmentState[]? LicenseAssignmentStates { get; set; }
        public string? Mail { get; set; }
        public MailboxSettings? MailboxSettings { get; set; }
        public string? MailNickname { get; set; }
        public string? MobilePhone { get; set; }
        public string? MySite { get; set; }
        public string? OfficeLocation { get; set; }
        public string? OnPremisesDistinguishedName { get; set; }
        public string? OnPremisesDomainName { get; set; }
        public OnPremisesExtensionAttributes? OnPremisesExtensionAttributes { get; set; }
        public string? OnPremisesImmutableId { get; set; }
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
        public OnPremisesProvisioningError[]? OnPremisesProvisioningErrors { get; set; }
        public string? OnPremisesSamAccountName { get; set; }
        public string? OnPremisesSecurityIdentifier { get; set; }
        public bool? OnPremisesSyncEnabled { get; set; }
        public string? OnPremisesUserPrincipalName { get; set; }
        public String[]? OtherMails { get; set; }
        public string? PasswordPolicies { get; set; }
        public PasswordProfile? PasswordProfile { get; set; }
        public String[]? PastProjects { get; set; }
        public string? PostalCode { get; set; }
        public string? PreferredDataLocation { get; set; }
        public string? PreferredLanguage { get; set; }
        public string? PreferredName { get; set; }
        public ProvisionedPlan[]? ProvisionedPlans { get; set; }
        public String[]? ProxyAddresses { get; set; }
        public DateTimeOffset? RefreshTokensValidFromDateTime { get; set; }
        public String[]? Responsibilities { get; set; }
        public String[]? Schools { get; set; }
        public bool? ShowInAddressList { get; set; }
        public String[]? Skills { get; set; }
        public DateTimeOffset? SignInSessionsValidFromDateTime { get; set; }
        public string? State { get; set; }
        public string? StreetAddress { get; set; }
        public string? Surname { get; set; }
        public string? UsageLocation { get; set; }
        public string? UserPrincipalName { get; set; }
        public string? UserType { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/administrativeunit-get-members?view=graph-rest-1.0
        /// </summary>
        public async Task<AdministrativeunitGetMembersResponse> AdministrativeunitGetMembersAsync()
        {
            var p = new AdministrativeunitGetMembersParameter();
            return await this.SendAsync<AdministrativeunitGetMembersParameter, AdministrativeunitGetMembersResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/administrativeunit-get-members?view=graph-rest-1.0
        /// </summary>
        public async Task<AdministrativeunitGetMembersResponse> AdministrativeunitGetMembersAsync(CancellationToken cancellationToken)
        {
            var p = new AdministrativeunitGetMembersParameter();
            return await this.SendAsync<AdministrativeunitGetMembersParameter, AdministrativeunitGetMembersResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/administrativeunit-get-members?view=graph-rest-1.0
        /// </summary>
        public async Task<AdministrativeunitGetMembersResponse> AdministrativeunitGetMembersAsync(AdministrativeunitGetMembersParameter parameter)
        {
            return await this.SendAsync<AdministrativeunitGetMembersParameter, AdministrativeunitGetMembersResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/administrativeunit-get-members?view=graph-rest-1.0
        /// </summary>
        public async Task<AdministrativeunitGetMembersResponse> AdministrativeunitGetMembersAsync(AdministrativeunitGetMembersParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<AdministrativeunitGetMembersParameter, AdministrativeunitGetMembersResponse>(parameter, cancellationToken);
        }
    }
}
