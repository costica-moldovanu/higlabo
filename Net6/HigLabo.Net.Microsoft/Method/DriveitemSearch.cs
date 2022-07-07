﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class DriveitemSearchParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
        }
        public enum ApiPath
        {
            Drives_DriveId_Root_Search,
            Groups_GroupId_Drive_Root_Search,
            Me_Drive_Root_Search,
            Sites_SiteId_Drive_Root_Search,
            Users_UserId_Drive_Root_Search,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Drives_DriveId_Root_Search: return $"/drives/{DriveId}/root/search";
                    case ApiPath.Groups_GroupId_Drive_Root_Search: return $"/groups/{GroupId}/drive/root/search";
                    case ApiPath.Me_Drive_Root_Search: return $"/me/drive/root/search";
                    case ApiPath.Sites_SiteId_Drive_Root_Search: return $"/sites/{SiteId}/drive/root/search";
                    case ApiPath.Users_UserId_Drive_Root_Search: return $"/users/{UserId}/drive/root/search";
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
        public string GroupId { get; set; }
        public string SiteId { get; set; }
        public string UserId { get; set; }
    }
    public partial class DriveitemSearchResponse : RestApiResponse
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/resources/driveitem?view=graph-rest-1.0
        /// </summary>
        public partial class DriveItem
        {
            public Audio? Audio { get; set; }
            public Bundle? Bundle { get; set; }
            public Stream? Content { get; set; }
            public IdentitySet? CreatedBy { get; set; }
            public DateTimeOffset? CreatedDateTime { get; set; }
            public string? CTag { get; set; }
            public Deleted? Deleted { get; set; }
            public string? Description { get; set; }
            public string? ETag { get; set; }
            public File? File { get; set; }
            public FileSystemInfo? FileSystemInfo { get; set; }
            public Folder? Folder { get; set; }
            public string? Id { get; set; }
            public Image? Image { get; set; }
            public IdentitySet? LastModifiedBy { get; set; }
            public DateTimeOffset? LastModifiedDateTime { get; set; }
            public GeoCoordinates? Location { get; set; }
            public Malware? Malware { get; set; }
            public string? Name { get; set; }
            public Package? Package { get; set; }
            public ItemReference? ParentReference { get; set; }
            public PendingOperations? PendingOperations { get; set; }
            public Photo? Photo { get; set; }
            public PublicationFacet? Publication { get; set; }
            public RemoteItem? RemoteItem { get; set; }
            public Root? Root { get; set; }
            public SearchResult? SearchResult { get; set; }
            public Shared? Shared { get; set; }
            public SharePointIds? SharepointIds { get; set; }
            public Int64? Size { get; set; }
            public SpecialFolder? SpecialFolder { get; set; }
            public Video? Video { get; set; }
            public string? WebDavUrl { get; set; }
            public string? WebUrl { get; set; }
        }

        public DriveItem[] Value { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/driveitem-search?view=graph-rest-1.0
        /// </summary>
        public async Task<DriveitemSearchResponse> DriveitemSearchAsync()
        {
            var p = new DriveitemSearchParameter();
            return await this.SendAsync<DriveitemSearchParameter, DriveitemSearchResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/driveitem-search?view=graph-rest-1.0
        /// </summary>
        public async Task<DriveitemSearchResponse> DriveitemSearchAsync(CancellationToken cancellationToken)
        {
            var p = new DriveitemSearchParameter();
            return await this.SendAsync<DriveitemSearchParameter, DriveitemSearchResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/driveitem-search?view=graph-rest-1.0
        /// </summary>
        public async Task<DriveitemSearchResponse> DriveitemSearchAsync(DriveitemSearchParameter parameter)
        {
            return await this.SendAsync<DriveitemSearchParameter, DriveitemSearchResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/driveitem-search?view=graph-rest-1.0
        /// </summary>
        public async Task<DriveitemSearchResponse> DriveitemSearchAsync(DriveitemSearchParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<DriveitemSearchParameter, DriveitemSearchResponse>(parameter, cancellationToken);
        }
    }
}
