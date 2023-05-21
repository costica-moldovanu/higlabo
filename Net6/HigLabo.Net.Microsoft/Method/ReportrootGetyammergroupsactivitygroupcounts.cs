﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getyammergroupsactivitygroupcounts?view=graph-rest-1.0
    /// </summary>
    public partial class ReportRootGetyammerGroupsactivityGroupcountsParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Reports_GetYammerGroupsActivityGroupCounts: return $"/reports/getYammerGroupsActivityGroupCounts";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Reports_GetYammerGroupsActivityGroupCounts,
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
    public partial class ReportRootGetyammerGroupsactivityGroupcountsResponse : RestApiResponse
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getyammergroupsactivitygroupcounts?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getyammergroupsactivitygroupcounts?view=graph-rest-1.0
        /// </summary>
        public async Task<ReportRootGetyammerGroupsactivityGroupcountsResponse> ReportRootGetyammerGroupsactivityGroupcountsAsync()
        {
            var p = new ReportRootGetyammerGroupsactivityGroupcountsParameter();
            return await this.SendAsync<ReportRootGetyammerGroupsactivityGroupcountsParameter, ReportRootGetyammerGroupsactivityGroupcountsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getyammergroupsactivitygroupcounts?view=graph-rest-1.0
        /// </summary>
        public async Task<ReportRootGetyammerGroupsactivityGroupcountsResponse> ReportRootGetyammerGroupsactivityGroupcountsAsync(CancellationToken cancellationToken)
        {
            var p = new ReportRootGetyammerGroupsactivityGroupcountsParameter();
            return await this.SendAsync<ReportRootGetyammerGroupsactivityGroupcountsParameter, ReportRootGetyammerGroupsactivityGroupcountsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getyammergroupsactivitygroupcounts?view=graph-rest-1.0
        /// </summary>
        public async Task<ReportRootGetyammerGroupsactivityGroupcountsResponse> ReportRootGetyammerGroupsactivityGroupcountsAsync(ReportRootGetyammerGroupsactivityGroupcountsParameter parameter)
        {
            return await this.SendAsync<ReportRootGetyammerGroupsactivityGroupcountsParameter, ReportRootGetyammerGroupsactivityGroupcountsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getyammergroupsactivitygroupcounts?view=graph-rest-1.0
        /// </summary>
        public async Task<ReportRootGetyammerGroupsactivityGroupcountsResponse> ReportRootGetyammerGroupsactivityGroupcountsAsync(ReportRootGetyammerGroupsactivityGroupcountsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ReportRootGetyammerGroupsactivityGroupcountsParameter, ReportRootGetyammerGroupsactivityGroupcountsResponse>(parameter, cancellationToken);
        }
    }
}
