﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class ItemanalyticsGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
        }
        public enum ApiPath
        {
            Drives_DriveId_Items_ItemId_Analytics_AllTime,
            Sites_SiteId_Analytics_AllTime,
            Sites_SiteId_Lists_ListId_Items_ItemId_Analytics_AllTime,
            Drives_DriveId_Items_ItemId_Analytics_LastSevenDays,
            Sites_SiteId_Analytics_LastSevenDays,
            Sites_SiteId_Lists_ListId_Items_ItemId_Analytics_LastSevenDays,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Drives_DriveId_Items_ItemId_Analytics_AllTime: return $"/drives/{DriveId}/items/{ItemId}/analytics/allTime";
                    case ApiPath.Sites_SiteId_Analytics_AllTime: return $"/sites/{SiteId}/analytics/allTime";
                    case ApiPath.Sites_SiteId_Lists_ListId_Items_ItemId_Analytics_AllTime: return $"/sites/{SiteId}/lists/{ListId}/items/{ItemId}/analytics/allTime";
                    case ApiPath.Drives_DriveId_Items_ItemId_Analytics_LastSevenDays: return $"/drives/{DriveId}/items/{ItemId}/analytics/lastSevenDays";
                    case ApiPath.Sites_SiteId_Analytics_LastSevenDays: return $"/sites/{SiteId}/analytics/lastSevenDays";
                    case ApiPath.Sites_SiteId_Lists_ListId_Items_ItemId_Analytics_LastSevenDays: return $"/sites/{SiteId}/lists/{ListId}/items/{ItemId}/analytics/lastSevenDays";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
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
        public string DriveId { get; set; }
        public string ItemId { get; set; }
        public string SiteId { get; set; }
        public string ListId { get; set; }
    }
    public partial class ItemanalyticsGetResponse : RestApiResponse
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/resources/itemanalytics?view=graph-rest-1.0
        /// </summary>
        public partial class ItemAnalytics
        {
            public ItemActivityStat? AllTime { get; set; }
            public ItemActivityStat? LastSevenDays { get; set; }
        }

        public ItemAnalytics[] Value { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/itemanalytics-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ItemanalyticsGetResponse> ItemanalyticsGetAsync()
        {
            var p = new ItemanalyticsGetParameter();
            return await this.SendAsync<ItemanalyticsGetParameter, ItemanalyticsGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/itemanalytics-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ItemanalyticsGetResponse> ItemanalyticsGetAsync(CancellationToken cancellationToken)
        {
            var p = new ItemanalyticsGetParameter();
            return await this.SendAsync<ItemanalyticsGetParameter, ItemanalyticsGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/itemanalytics-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ItemanalyticsGetResponse> ItemanalyticsGetAsync(ItemanalyticsGetParameter parameter)
        {
            return await this.SendAsync<ItemanalyticsGetParameter, ItemanalyticsGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/itemanalytics-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ItemanalyticsGetResponse> ItemanalyticsGetAsync(ItemanalyticsGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ItemanalyticsGetParameter, ItemanalyticsGetResponse>(parameter, cancellationToken);
        }
    }
}
