﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class ServiceprincipalListClaimsmappingpoliciesParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string Id { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.ServicePrincipals_Id_ClaimsMappingPolicies: return $"/servicePrincipals/{Id}/claimsMappingPolicies";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
            Id,
            Definition,
            Description,
            DisplayName,
            IsOrganizationDefault,
            AppliesTo,
        }
        public enum ApiPath
        {
            ServicePrincipals_Id_ClaimsMappingPolicies,
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
    public partial class ServiceprincipalListClaimsmappingpoliciesResponse : RestApiResponse
    {
        public ClaimsMappingPolicy[] Value { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-list-claimsmappingpolicies?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalListClaimsmappingpoliciesResponse> ServiceprincipalListClaimsmappingpoliciesAsync()
        {
            var p = new ServiceprincipalListClaimsmappingpoliciesParameter();
            return await this.SendAsync<ServiceprincipalListClaimsmappingpoliciesParameter, ServiceprincipalListClaimsmappingpoliciesResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-list-claimsmappingpolicies?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalListClaimsmappingpoliciesResponse> ServiceprincipalListClaimsmappingpoliciesAsync(CancellationToken cancellationToken)
        {
            var p = new ServiceprincipalListClaimsmappingpoliciesParameter();
            return await this.SendAsync<ServiceprincipalListClaimsmappingpoliciesParameter, ServiceprincipalListClaimsmappingpoliciesResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-list-claimsmappingpolicies?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalListClaimsmappingpoliciesResponse> ServiceprincipalListClaimsmappingpoliciesAsync(ServiceprincipalListClaimsmappingpoliciesParameter parameter)
        {
            return await this.SendAsync<ServiceprincipalListClaimsmappingpoliciesParameter, ServiceprincipalListClaimsmappingpoliciesResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-list-claimsmappingpolicies?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalListClaimsmappingpoliciesResponse> ServiceprincipalListClaimsmappingpoliciesAsync(ServiceprincipalListClaimsmappingpoliciesParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ServiceprincipalListClaimsmappingpoliciesParameter, ServiceprincipalListClaimsmappingpoliciesResponse>(parameter, cancellationToken);
        }
    }
}
