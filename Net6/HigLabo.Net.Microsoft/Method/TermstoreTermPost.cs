﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class TermstoreTermPostParameter : IRestApiParameter
    {
        public enum ApiPath
        {
            Ites_SiteId_TermStore_Sets_SetId_Children,
            Ites_SiteId_TermStore_Sets_SetId_Terms_TermId_Children,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Ites_SiteId_TermStore_Sets_SetId_Children: return $"/ites/{SiteId}/termStore/sets/{SetId}/children";
                    case ApiPath.Ites_SiteId_TermStore_Sets_SetId_Terms_TermId_Children: return $"/ites/{SiteId}/termStore/sets/{SetId}/terms/{TermId}/children";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public TermStoreLocalizedLabel[]? Labels { get; set; }
        public string SiteId { get; set; }
        public string SetId { get; set; }
        public string TermId { get; set; }
    }
    public partial class TermstoreTermPostResponse : RestApiResponse
    {
        public DateTimeOffset? CreatedDateTime { get; set; }
        public TermStoreLocalizedDescription[]? Descriptions { get; set; }
        public string? Id { get; set; }
        public TermStoreLocalizedLabel[]? Labels { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public KeyValue[]? Properties { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/termstore-term-post?view=graph-rest-1.0
        /// </summary>
        public async Task<TermstoreTermPostResponse> TermstoreTermPostAsync()
        {
            var p = new TermstoreTermPostParameter();
            return await this.SendAsync<TermstoreTermPostParameter, TermstoreTermPostResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/termstore-term-post?view=graph-rest-1.0
        /// </summary>
        public async Task<TermstoreTermPostResponse> TermstoreTermPostAsync(CancellationToken cancellationToken)
        {
            var p = new TermstoreTermPostParameter();
            return await this.SendAsync<TermstoreTermPostParameter, TermstoreTermPostResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/termstore-term-post?view=graph-rest-1.0
        /// </summary>
        public async Task<TermstoreTermPostResponse> TermstoreTermPostAsync(TermstoreTermPostParameter parameter)
        {
            return await this.SendAsync<TermstoreTermPostParameter, TermstoreTermPostResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/termstore-term-post?view=graph-rest-1.0
        /// </summary>
        public async Task<TermstoreTermPostResponse> TermstoreTermPostAsync(TermstoreTermPostParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<TermstoreTermPostParameter, TermstoreTermPostResponse>(parameter, cancellationToken);
        }
    }
}
