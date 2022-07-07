﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class TermsofusecontainerPostAgreementsParameter : IRestApiParameter
    {
        public enum ApiPath
        {
            IdentityGovernance_TermsOfUse_Agreements,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.IdentityGovernance_TermsOfUse_Agreements: return $"/identityGovernance/termsOfUse/agreements";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string? DisplayName { get; set; }
        public bool? IsViewingBeforeAcceptanceRequired { get; set; }
        public string? FileName { get; set; }
        public bool? IsDefault { get; set; }
        public string? Language { get; set; }
        public string? Data { get; set; }
    }
    public partial class TermsofusecontainerPostAgreementsResponse : RestApiResponse
    {
        public string? DisplayName { get; set; }
        public string? Id { get; set; }
        public bool? IsPerDeviceAcceptanceRequired { get; set; }
        public bool? IsViewingBeforeAcceptanceRequired { get; set; }
        public TermsExpiration? TermsExpiration { get; set; }
        public string? UserReacceptRequiredFrequency { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/termsofusecontainer-post-agreements?view=graph-rest-1.0
        /// </summary>
        public async Task<TermsofusecontainerPostAgreementsResponse> TermsofusecontainerPostAgreementsAsync()
        {
            var p = new TermsofusecontainerPostAgreementsParameter();
            return await this.SendAsync<TermsofusecontainerPostAgreementsParameter, TermsofusecontainerPostAgreementsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/termsofusecontainer-post-agreements?view=graph-rest-1.0
        /// </summary>
        public async Task<TermsofusecontainerPostAgreementsResponse> TermsofusecontainerPostAgreementsAsync(CancellationToken cancellationToken)
        {
            var p = new TermsofusecontainerPostAgreementsParameter();
            return await this.SendAsync<TermsofusecontainerPostAgreementsParameter, TermsofusecontainerPostAgreementsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/termsofusecontainer-post-agreements?view=graph-rest-1.0
        /// </summary>
        public async Task<TermsofusecontainerPostAgreementsResponse> TermsofusecontainerPostAgreementsAsync(TermsofusecontainerPostAgreementsParameter parameter)
        {
            return await this.SendAsync<TermsofusecontainerPostAgreementsParameter, TermsofusecontainerPostAgreementsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/termsofusecontainer-post-agreements?view=graph-rest-1.0
        /// </summary>
        public async Task<TermsofusecontainerPostAgreementsResponse> TermsofusecontainerPostAgreementsAsync(TermsofusecontainerPostAgreementsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<TermsofusecontainerPostAgreementsParameter, TermsofusecontainerPostAgreementsResponse>(parameter, cancellationToken);
        }
    }
}
