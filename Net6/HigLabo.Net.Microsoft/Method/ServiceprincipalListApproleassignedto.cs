﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class ServiceprincipalListApproleassignedtoParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string Id { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.ServicePrincipals_Id_AppRoleAssignedTo: return $"/servicePrincipals/{Id}/appRoleAssignedTo";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
            AppRoleId,
            CreatedDateTime,
            Id,
            PrincipalDisplayName,
            PrincipalId,
            PrincipalType,
            ResourceDisplayName,
            ResourceId,
        }
        public enum ApiPath
        {
            ServicePrincipals_Id_AppRoleAssignedTo,
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
    public partial class ServiceprincipalListApproleassignedtoResponse : RestApiResponse
    {
        public AppRoleAssignment[] Value { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-list-approleassignedto?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalListApproleassignedtoResponse> ServiceprincipalListApproleassignedtoAsync()
        {
            var p = new ServiceprincipalListApproleassignedtoParameter();
            return await this.SendAsync<ServiceprincipalListApproleassignedtoParameter, ServiceprincipalListApproleassignedtoResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-list-approleassignedto?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalListApproleassignedtoResponse> ServiceprincipalListApproleassignedtoAsync(CancellationToken cancellationToken)
        {
            var p = new ServiceprincipalListApproleassignedtoParameter();
            return await this.SendAsync<ServiceprincipalListApproleassignedtoParameter, ServiceprincipalListApproleassignedtoResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-list-approleassignedto?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalListApproleassignedtoResponse> ServiceprincipalListApproleassignedtoAsync(ServiceprincipalListApproleassignedtoParameter parameter)
        {
            return await this.SendAsync<ServiceprincipalListApproleassignedtoParameter, ServiceprincipalListApproleassignedtoResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/serviceprincipal-list-approleassignedto?view=graph-rest-1.0
        /// </summary>
        public async Task<ServiceprincipalListApproleassignedtoResponse> ServiceprincipalListApproleassignedtoAsync(ServiceprincipalListApproleassignedtoParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ServiceprincipalListApproleassignedtoParameter, ServiceprincipalListApproleassignedtoResponse>(parameter, cancellationToken);
        }
    }
}
