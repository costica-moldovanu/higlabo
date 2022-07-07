﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class DomainPostDomainsParameter : IRestApiParameter
    {
        public enum ApiPath
        {
            Domains,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Domains: return $"/domains";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
    }
    public partial class DomainPostDomainsResponse : RestApiResponse
    {
        public string? AuthenticationType { get; set; }
        public string? AvailabilityStatus { get; set; }
        public string? Id { get; set; }
        public bool? IsAdminManaged { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsInitial { get; set; }
        public bool? IsRoot { get; set; }
        public bool? IsVerified { get; set; }
        public Int32? PasswordNotificationWindowInDays { get; set; }
        public Int32? PasswordValidityPeriodInDays { get; set; }
        public String[]? SupportedServices { get; set; }
        public DomainState? State { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/domain-post-domains?view=graph-rest-1.0
        /// </summary>
        public async Task<DomainPostDomainsResponse> DomainPostDomainsAsync()
        {
            var p = new DomainPostDomainsParameter();
            return await this.SendAsync<DomainPostDomainsParameter, DomainPostDomainsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/domain-post-domains?view=graph-rest-1.0
        /// </summary>
        public async Task<DomainPostDomainsResponse> DomainPostDomainsAsync(CancellationToken cancellationToken)
        {
            var p = new DomainPostDomainsParameter();
            return await this.SendAsync<DomainPostDomainsParameter, DomainPostDomainsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/domain-post-domains?view=graph-rest-1.0
        /// </summary>
        public async Task<DomainPostDomainsResponse> DomainPostDomainsAsync(DomainPostDomainsParameter parameter)
        {
            return await this.SendAsync<DomainPostDomainsParameter, DomainPostDomainsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/domain-post-domains?view=graph-rest-1.0
        /// </summary>
        public async Task<DomainPostDomainsResponse> DomainPostDomainsAsync(DomainPostDomainsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<DomainPostDomainsParameter, DomainPostDomainsResponse>(parameter, cancellationToken);
        }
    }
}
