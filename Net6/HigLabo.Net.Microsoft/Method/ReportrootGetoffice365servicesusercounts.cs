﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class ReportRootGetoffice365servicesUsercountsParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Reports_GetOffice365ServicesUserCounts: return $"/reports/getOffice365ServicesUserCounts";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Reports_GetOffice365ServicesUserCounts,
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
    public partial class ReportRootGetoffice365servicesUsercountsResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/reportroot-getoffice365servicesusercounts?view=graph-rest-1.0
        /// </summary>
        public async Task<ReportRootGetoffice365servicesUsercountsResponse> ReportRootGetoffice365servicesUsercountsAsync()
        {
            var p = new ReportRootGetoffice365servicesUsercountsParameter();
            return await this.SendAsync<ReportRootGetoffice365servicesUsercountsParameter, ReportRootGetoffice365servicesUsercountsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/reportroot-getoffice365servicesusercounts?view=graph-rest-1.0
        /// </summary>
        public async Task<ReportRootGetoffice365servicesUsercountsResponse> ReportRootGetoffice365servicesUsercountsAsync(CancellationToken cancellationToken)
        {
            var p = new ReportRootGetoffice365servicesUsercountsParameter();
            return await this.SendAsync<ReportRootGetoffice365servicesUsercountsParameter, ReportRootGetoffice365servicesUsercountsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/reportroot-getoffice365servicesusercounts?view=graph-rest-1.0
        /// </summary>
        public async Task<ReportRootGetoffice365servicesUsercountsResponse> ReportRootGetoffice365servicesUsercountsAsync(ReportRootGetoffice365servicesUsercountsParameter parameter)
        {
            return await this.SendAsync<ReportRootGetoffice365servicesUsercountsParameter, ReportRootGetoffice365servicesUsercountsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/reportroot-getoffice365servicesusercounts?view=graph-rest-1.0
        /// </summary>
        public async Task<ReportRootGetoffice365servicesUsercountsResponse> ReportRootGetoffice365servicesUsercountsAsync(ReportRootGetoffice365servicesUsercountsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ReportRootGetoffice365servicesUsercountsParameter, ReportRootGetoffice365servicesUsercountsResponse>(parameter, cancellationToken);
        }
    }
}
