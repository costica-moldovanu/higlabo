﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class IntuneMamMdmwindowsinformationprotectionpolicyCreateParameter : IRestApiParameter
    {
        public enum IntuneMamMdmwindowsinformationprotectionpolicyCreateParameterWindowsInformationProtectionEnforcementLevel
        {
            NoProtection,
            EncryptAndAuditOnly,
            EncryptAuditAndPrompt,
            EncryptAuditAndBlock,
        }
        public enum ApiPath
        {
            DeviceAppManagement_MdmWindowsInformationProtectionPolicies,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.DeviceAppManagement_MdmWindowsInformationProtectionPolicies: return $"/deviceAppManagement/mdmWindowsInformationProtectionPolicies";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string? DisplayName { get; set; }
        public string? Description { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string? Id { get; set; }
        public string? Version { get; set; }
        public IntuneMamMdmwindowsinformationprotectionpolicyCreateParameterWindowsInformationProtectionEnforcementLevel EnforcementLevel { get; set; }
        public string? EnterpriseDomain { get; set; }
        public WindowsInformationProtectionResourceCollection[]? EnterpriseProtectedDomainNames { get; set; }
        public bool? ProtectionUnderLockConfigRequired { get; set; }
        public WindowsInformationProtectionDataRecoveryCertificate? DataRecoveryCertificate { get; set; }
        public bool? RevokeOnUnenrollDisabled { get; set; }
        public Guid? RightsManagementServicesTemplateId { get; set; }
        public bool? AzureRightsManagementServicesAllowed { get; set; }
        public bool? IconsVisible { get; set; }
        public WindowsInformationProtectionApp[]? ProtectedApps { get; set; }
        public WindowsInformationProtectionApp[]? ExemptApps { get; set; }
        public WindowsInformationProtectionResourceCollection[]? EnterpriseNetworkDomainNames { get; set; }
        public WindowsInformationProtectionProxiedDomainCollection[]? EnterpriseProxiedDomains { get; set; }
        public WindowsInformationProtectionIPRangeCollection[]? EnterpriseIPRanges { get; set; }
        public bool? EnterpriseIPRangesAreAuthoritative { get; set; }
        public WindowsInformationProtectionResourceCollection[]? EnterpriseProxyServers { get; set; }
        public WindowsInformationProtectionResourceCollection[]? EnterpriseInternalProxyServers { get; set; }
        public bool? EnterpriseProxyServersAreAuthoritative { get; set; }
        public WindowsInformationProtectionResourceCollection[]? NeutralDomainResources { get; set; }
        public bool? IndexingEncryptedStoresOrItemsBlocked { get; set; }
        public WindowsInformationProtectionResourceCollection[]? SmbAutoEncryptedFileExtensions { get; set; }
        public bool? IsAssigned { get; set; }
    }
    public partial class IntuneMamMdmwindowsinformationprotectionpolicyCreateResponse : RestApiResponse
    {
        public enum MdmWindowsInformationProtectionPolicyWindowsInformationProtectionEnforcementLevel
        {
            NoProtection,
            EncryptAndAuditOnly,
            EncryptAuditAndPrompt,
            EncryptAuditAndBlock,
        }

        public string? DisplayName { get; set; }
        public string? Description { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string? Id { get; set; }
        public string? Version { get; set; }
        public WindowsInformationProtectionEnforcementLevel? EnforcementLevel { get; set; }
        public string? EnterpriseDomain { get; set; }
        public WindowsInformationProtectionResourceCollection[]? EnterpriseProtectedDomainNames { get; set; }
        public bool? ProtectionUnderLockConfigRequired { get; set; }
        public WindowsInformationProtectionDataRecoveryCertificate? DataRecoveryCertificate { get; set; }
        public bool? RevokeOnUnenrollDisabled { get; set; }
        public Guid? RightsManagementServicesTemplateId { get; set; }
        public bool? AzureRightsManagementServicesAllowed { get; set; }
        public bool? IconsVisible { get; set; }
        public WindowsInformationProtectionApp[]? ProtectedApps { get; set; }
        public WindowsInformationProtectionApp[]? ExemptApps { get; set; }
        public WindowsInformationProtectionResourceCollection[]? EnterpriseNetworkDomainNames { get; set; }
        public WindowsInformationProtectionProxiedDomainCollection[]? EnterpriseProxiedDomains { get; set; }
        public WindowsInformationProtectionIPRangeCollection[]? EnterpriseIPRanges { get; set; }
        public bool? EnterpriseIPRangesAreAuthoritative { get; set; }
        public WindowsInformationProtectionResourceCollection[]? EnterpriseProxyServers { get; set; }
        public WindowsInformationProtectionResourceCollection[]? EnterpriseInternalProxyServers { get; set; }
        public bool? EnterpriseProxyServersAreAuthoritative { get; set; }
        public WindowsInformationProtectionResourceCollection[]? NeutralDomainResources { get; set; }
        public bool? IndexingEncryptedStoresOrItemsBlocked { get; set; }
        public WindowsInformationProtectionResourceCollection[]? SmbAutoEncryptedFileExtensions { get; set; }
        public bool? IsAssigned { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-mam-mdmwindowsinformationprotectionpolicy-create?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneMamMdmwindowsinformationprotectionpolicyCreateResponse> IntuneMamMdmwindowsinformationprotectionpolicyCreateAsync()
        {
            var p = new IntuneMamMdmwindowsinformationprotectionpolicyCreateParameter();
            return await this.SendAsync<IntuneMamMdmwindowsinformationprotectionpolicyCreateParameter, IntuneMamMdmwindowsinformationprotectionpolicyCreateResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-mam-mdmwindowsinformationprotectionpolicy-create?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneMamMdmwindowsinformationprotectionpolicyCreateResponse> IntuneMamMdmwindowsinformationprotectionpolicyCreateAsync(CancellationToken cancellationToken)
        {
            var p = new IntuneMamMdmwindowsinformationprotectionpolicyCreateParameter();
            return await this.SendAsync<IntuneMamMdmwindowsinformationprotectionpolicyCreateParameter, IntuneMamMdmwindowsinformationprotectionpolicyCreateResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-mam-mdmwindowsinformationprotectionpolicy-create?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneMamMdmwindowsinformationprotectionpolicyCreateResponse> IntuneMamMdmwindowsinformationprotectionpolicyCreateAsync(IntuneMamMdmwindowsinformationprotectionpolicyCreateParameter parameter)
        {
            return await this.SendAsync<IntuneMamMdmwindowsinformationprotectionpolicyCreateParameter, IntuneMamMdmwindowsinformationprotectionpolicyCreateResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-mam-mdmwindowsinformationprotectionpolicy-create?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneMamMdmwindowsinformationprotectionpolicyCreateResponse> IntuneMamMdmwindowsinformationprotectionpolicyCreateAsync(IntuneMamMdmwindowsinformationprotectionpolicyCreateParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<IntuneMamMdmwindowsinformationprotectionpolicyCreateParameter, IntuneMamMdmwindowsinformationprotectionpolicyCreateResponse>(parameter, cancellationToken);
        }
    }
}
