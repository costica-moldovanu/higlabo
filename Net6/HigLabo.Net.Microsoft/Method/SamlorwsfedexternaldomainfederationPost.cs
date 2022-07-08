﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class SamlorwsfedexternaldomainfederationPostParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Directory_FederationConfigurations: return $"/directory/federationConfigurations";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum SamlorwsfedexternaldomainfederationPostParameterAuthenticationProtocol
        {
            WsFed,
            Saml,
        }
        public enum SamlOrWsFedExternalDomainFederationAuthenticationProtocol
        {
            WsFed,
            Saml,
            UnknownFutureValue,
        }
        public enum ApiPath
        {
            Directory_FederationConfigurations,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string? DisplayName { get; set; }
        public string? IssuerUri { get; set; }
        public string? MetadataExchangeUri { get; set; }
        public string? PassiveSignInUri { get; set; }
        public SamlorwsfedexternaldomainfederationPostParameterAuthenticationProtocol PreferredAuthenticationProtocol { get; set; }
        public string? SigningCertificate { get; set; }
        public string? Id { get; set; }
        public ExternalDomainName[]? Domains { get; set; }
    }
    public partial class SamlorwsfedexternaldomainfederationPostResponse : RestApiResponse
    {
        public enum SamlOrWsFedExternalDomainFederationAuthenticationProtocol
        {
            WsFed,
            Saml,
            UnknownFutureValue,
        }

        public string? DisplayName { get; set; }
        public string? Id { get; set; }
        public string? IssuerUri { get; set; }
        public string? MetadataExchangeUri { get; set; }
        public string? PassiveSignInUri { get; set; }
        public SamlOrWsFedExternalDomainFederationAuthenticationProtocol PreferredAuthenticationProtocol { get; set; }
        public string? SigningCertificate { get; set; }
        public ExternalDomainName[]? Domains { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/samlorwsfedexternaldomainfederation-post?view=graph-rest-1.0
        /// </summary>
        public async Task<SamlorwsfedexternaldomainfederationPostResponse> SamlorwsfedexternaldomainfederationPostAsync()
        {
            var p = new SamlorwsfedexternaldomainfederationPostParameter();
            return await this.SendAsync<SamlorwsfedexternaldomainfederationPostParameter, SamlorwsfedexternaldomainfederationPostResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/samlorwsfedexternaldomainfederation-post?view=graph-rest-1.0
        /// </summary>
        public async Task<SamlorwsfedexternaldomainfederationPostResponse> SamlorwsfedexternaldomainfederationPostAsync(CancellationToken cancellationToken)
        {
            var p = new SamlorwsfedexternaldomainfederationPostParameter();
            return await this.SendAsync<SamlorwsfedexternaldomainfederationPostParameter, SamlorwsfedexternaldomainfederationPostResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/samlorwsfedexternaldomainfederation-post?view=graph-rest-1.0
        /// </summary>
        public async Task<SamlorwsfedexternaldomainfederationPostResponse> SamlorwsfedexternaldomainfederationPostAsync(SamlorwsfedexternaldomainfederationPostParameter parameter)
        {
            return await this.SendAsync<SamlorwsfedexternaldomainfederationPostParameter, SamlorwsfedexternaldomainfederationPostResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/samlorwsfedexternaldomainfederation-post?view=graph-rest-1.0
        /// </summary>
        public async Task<SamlorwsfedexternaldomainfederationPostResponse> SamlorwsfedexternaldomainfederationPostAsync(SamlorwsfedexternaldomainfederationPostParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<SamlorwsfedexternaldomainfederationPostParameter, SamlorwsfedexternaldomainfederationPostResponse>(parameter, cancellationToken);
        }
    }
}
