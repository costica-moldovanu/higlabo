﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class RichlongrunningoperationGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
        }
        public enum ApiPath
        {
            Sites_SiteId_Operations_RichLongRunningOperationID,
            Sites_SiteId_Lists_ListId_Operations_RichLongRunningOperationID,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Sites_SiteId_Operations_RichLongRunningOperationID: return $"/sites/{SiteId}/operations/{RichLongRunningOperationID}";
                    case ApiPath.Sites_SiteId_Lists_ListId_Operations_RichLongRunningOperationID: return $"/sites/{SiteId}/lists/{ListId}/operations/{RichLongRunningOperationID}";
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
        public string SiteId { get; set; }
        public string RichLongRunningOperationID { get; set; }
        public string ListId { get; set; }
    }
    public partial class RichlongrunningoperationGetResponse : RestApiResponse
    {
        public enum RichLongRunningOperationLongRunningOperationStatus
        {
            NotStarted,
            Running,
            Succeeded,
            Failed,
            UnknownFutureValue,
        }

        public DateTimeOffset? CreatedDateTime { get; set; }
        public PublicError? Error { get; set; }
        public string? Id { get; set; }
        public DateTimeOffset? LastActionDateTime { get; set; }
        public Int32? PercentageComplete { get; set; }
        public string? ResourceId { get; set; }
        public string? ResourceLocation { get; set; }
        public RichLongRunningOperationLongRunningOperationStatus Status { get; set; }
        public string? StatusDetail { get; set; }
        public string? Type { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/richlongrunningoperation-get?view=graph-rest-1.0
        /// </summary>
        public async Task<RichlongrunningoperationGetResponse> RichlongrunningoperationGetAsync()
        {
            var p = new RichlongrunningoperationGetParameter();
            return await this.SendAsync<RichlongrunningoperationGetParameter, RichlongrunningoperationGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/richlongrunningoperation-get?view=graph-rest-1.0
        /// </summary>
        public async Task<RichlongrunningoperationGetResponse> RichlongrunningoperationGetAsync(CancellationToken cancellationToken)
        {
            var p = new RichlongrunningoperationGetParameter();
            return await this.SendAsync<RichlongrunningoperationGetParameter, RichlongrunningoperationGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/richlongrunningoperation-get?view=graph-rest-1.0
        /// </summary>
        public async Task<RichlongrunningoperationGetResponse> RichlongrunningoperationGetAsync(RichlongrunningoperationGetParameter parameter)
        {
            return await this.SendAsync<RichlongrunningoperationGetParameter, RichlongrunningoperationGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/richlongrunningoperation-get?view=graph-rest-1.0
        /// </summary>
        public async Task<RichlongrunningoperationGetResponse> RichlongrunningoperationGetAsync(RichlongrunningoperationGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<RichlongrunningoperationGetParameter, RichlongrunningoperationGetResponse>(parameter, cancellationToken);
        }
    }
}
