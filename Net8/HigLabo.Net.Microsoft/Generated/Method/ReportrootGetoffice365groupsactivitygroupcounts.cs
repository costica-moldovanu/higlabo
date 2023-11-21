﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365groupsactivitygroupcounts?view=graph-rest-1.0
    /// </summary>
    public partial class ReportRootGetoffice365GroupsactivityGroupcountsParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Reports_GetOffice365GroupsActivityGroupCounts: return $"/reports/getOffice365GroupsActivityGroupCounts";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Reports_GetOffice365GroupsActivityGroupCounts,
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
    public partial class ReportRootGetoffice365GroupsactivityGroupcountsResponse : RestApiResponse
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365groupsactivitygroupcounts?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365groupsactivitygroupcounts?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ReportRootGetoffice365GroupsactivityGroupcountsResponse> ReportRootGetoffice365GroupsactivityGroupcountsAsync()
        {
            var p = new ReportRootGetoffice365GroupsactivityGroupcountsParameter();
            return await this.SendAsync<ReportRootGetoffice365GroupsactivityGroupcountsParameter, ReportRootGetoffice365GroupsactivityGroupcountsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365groupsactivitygroupcounts?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ReportRootGetoffice365GroupsactivityGroupcountsResponse> ReportRootGetoffice365GroupsactivityGroupcountsAsync(CancellationToken cancellationToken)
        {
            var p = new ReportRootGetoffice365GroupsactivityGroupcountsParameter();
            return await this.SendAsync<ReportRootGetoffice365GroupsactivityGroupcountsParameter, ReportRootGetoffice365GroupsactivityGroupcountsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365groupsactivitygroupcounts?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ReportRootGetoffice365GroupsactivityGroupcountsResponse> ReportRootGetoffice365GroupsactivityGroupcountsAsync(ReportRootGetoffice365GroupsactivityGroupcountsParameter parameter)
        {
            return await this.SendAsync<ReportRootGetoffice365GroupsactivityGroupcountsParameter, ReportRootGetoffice365GroupsactivityGroupcountsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365groupsactivitygroupcounts?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ReportRootGetoffice365GroupsactivityGroupcountsResponse> ReportRootGetoffice365GroupsactivityGroupcountsAsync(ReportRootGetoffice365GroupsactivityGroupcountsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ReportRootGetoffice365GroupsactivityGroupcountsParameter, ReportRootGetoffice365GroupsactivityGroupcountsResponse>(parameter, cancellationToken);
        }
    }
}
