﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class SharesGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string ShareIdOrEncodedSharingUrl { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Shares_ShareIdOrEncodedSharingUrl: return $"/shares/{ShareIdOrEncodedSharingUrl}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Shares_ShareIdOrEncodedSharingUrl,
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
    public partial class SharesGetResponse : RestApiResponse
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public IdentitySet? Owner { get; set; }
        public DriveItem? DriveItem { get; set; }
        public SiteList? List { get; set; }
        public ListItem? ListItem { get; set; }
        public Permission? Permission { get; set; }
        public Site? Site { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/shares-get?view=graph-rest-1.0
        /// </summary>
        public async Task<SharesGetResponse> SharesGetAsync()
        {
            var p = new SharesGetParameter();
            return await this.SendAsync<SharesGetParameter, SharesGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/shares-get?view=graph-rest-1.0
        /// </summary>
        public async Task<SharesGetResponse> SharesGetAsync(CancellationToken cancellationToken)
        {
            var p = new SharesGetParameter();
            return await this.SendAsync<SharesGetParameter, SharesGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/shares-get?view=graph-rest-1.0
        /// </summary>
        public async Task<SharesGetResponse> SharesGetAsync(SharesGetParameter parameter)
        {
            return await this.SendAsync<SharesGetParameter, SharesGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/shares-get?view=graph-rest-1.0
        /// </summary>
        public async Task<SharesGetResponse> SharesGetAsync(SharesGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<SharesGetParameter, SharesGetResponse>(parameter, cancellationToken);
        }
    }
}
