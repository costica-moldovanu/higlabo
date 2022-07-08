﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class TemporaryAccesspassauthenticationmethodConfigurationDeleteParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Policies_AuthenticationMethodsPolicy_AuthenticationMethodConfigurations_TemporaryAccessPass: return $"/policies/authenticationMethodsPolicy/authenticationMethodConfigurations/temporaryAccessPass";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Policies_AuthenticationMethodsPolicy_AuthenticationMethodConfigurations_TemporaryAccessPass,
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
    public partial class TemporaryAccesspassauthenticationmethodConfigurationDeleteResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/temporaryaccesspassauthenticationmethodconfiguration-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<TemporaryAccesspassauthenticationmethodConfigurationDeleteResponse> TemporaryAccesspassauthenticationmethodConfigurationDeleteAsync()
        {
            var p = new TemporaryAccesspassauthenticationmethodConfigurationDeleteParameter();
            return await this.SendAsync<TemporaryAccesspassauthenticationmethodConfigurationDeleteParameter, TemporaryAccesspassauthenticationmethodConfigurationDeleteResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/temporaryaccesspassauthenticationmethodconfiguration-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<TemporaryAccesspassauthenticationmethodConfigurationDeleteResponse> TemporaryAccesspassauthenticationmethodConfigurationDeleteAsync(CancellationToken cancellationToken)
        {
            var p = new TemporaryAccesspassauthenticationmethodConfigurationDeleteParameter();
            return await this.SendAsync<TemporaryAccesspassauthenticationmethodConfigurationDeleteParameter, TemporaryAccesspassauthenticationmethodConfigurationDeleteResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/temporaryaccesspassauthenticationmethodconfiguration-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<TemporaryAccesspassauthenticationmethodConfigurationDeleteResponse> TemporaryAccesspassauthenticationmethodConfigurationDeleteAsync(TemporaryAccesspassauthenticationmethodConfigurationDeleteParameter parameter)
        {
            return await this.SendAsync<TemporaryAccesspassauthenticationmethodConfigurationDeleteParameter, TemporaryAccesspassauthenticationmethodConfigurationDeleteResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/temporaryaccesspassauthenticationmethodconfiguration-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<TemporaryAccesspassauthenticationmethodConfigurationDeleteResponse> TemporaryAccesspassauthenticationmethodConfigurationDeleteAsync(TemporaryAccesspassauthenticationmethodConfigurationDeleteParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<TemporaryAccesspassauthenticationmethodConfigurationDeleteParameter, TemporaryAccesspassauthenticationmethodConfigurationDeleteResponse>(parameter, cancellationToken);
        }
    }
}
