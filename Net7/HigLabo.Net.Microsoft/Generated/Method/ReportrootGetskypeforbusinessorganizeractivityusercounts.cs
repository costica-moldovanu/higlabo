﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getskypeforbusinessorganizeractivityusercounts?view=graph-rest-1.0
    /// </summary>
    public partial class ReportRootGetskypeforbusinessorganizeractivityUsercountsParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Reports_GetSkypeForBusinessOrganizerActivityUserCounts: return $"/reports/getSkypeForBusinessOrganizerActivityUserCounts";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Reports_GetSkypeForBusinessOrganizerActivityUserCounts,
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
    public partial class ReportRootGetskypeforbusinessorganizeractivityUsercountsResponse : RestApiResponse
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getskypeforbusinessorganizeractivityusercounts?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getskypeforbusinessorganizeractivityusercounts?view=graph-rest-1.0
        /// </summary>
        public async Task<ReportRootGetskypeforbusinessorganizeractivityUsercountsResponse> ReportRootGetskypeforbusinessorganizeractivityUsercountsAsync()
        {
            var p = new ReportRootGetskypeforbusinessorganizeractivityUsercountsParameter();
            return await this.SendAsync<ReportRootGetskypeforbusinessorganizeractivityUsercountsParameter, ReportRootGetskypeforbusinessorganizeractivityUsercountsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getskypeforbusinessorganizeractivityusercounts?view=graph-rest-1.0
        /// </summary>
        public async Task<ReportRootGetskypeforbusinessorganizeractivityUsercountsResponse> ReportRootGetskypeforbusinessorganizeractivityUsercountsAsync(CancellationToken cancellationToken)
        {
            var p = new ReportRootGetskypeforbusinessorganizeractivityUsercountsParameter();
            return await this.SendAsync<ReportRootGetskypeforbusinessorganizeractivityUsercountsParameter, ReportRootGetskypeforbusinessorganizeractivityUsercountsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getskypeforbusinessorganizeractivityusercounts?view=graph-rest-1.0
        /// </summary>
        public async Task<ReportRootGetskypeforbusinessorganizeractivityUsercountsResponse> ReportRootGetskypeforbusinessorganizeractivityUsercountsAsync(ReportRootGetskypeforbusinessorganizeractivityUsercountsParameter parameter)
        {
            return await this.SendAsync<ReportRootGetskypeforbusinessorganizeractivityUsercountsParameter, ReportRootGetskypeforbusinessorganizeractivityUsercountsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getskypeforbusinessorganizeractivityusercounts?view=graph-rest-1.0
        /// </summary>
        public async Task<ReportRootGetskypeforbusinessorganizeractivityUsercountsResponse> ReportRootGetskypeforbusinessorganizeractivityUsercountsAsync(ReportRootGetskypeforbusinessorganizeractivityUsercountsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ReportRootGetskypeforbusinessorganizeractivityUsercountsParameter, ReportRootGetskypeforbusinessorganizeractivityUsercountsResponse>(parameter, cancellationToken);
        }
    }
}
