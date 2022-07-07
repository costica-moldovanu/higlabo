﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class DriveitemRestoreParameter : IRestApiParameter
    {
        public enum ApiPath
        {
            Me_Drive_Items_ItemId_Restore,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Me_Drive_Items_ItemId_Restore: return $"/me/drive/items/{ItemId}/restore";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public ItemReference? ParentReference { get; set; }
        public string? Name { get; set; }
        public string ItemId { get; set; }
    }
    public partial class DriveitemRestoreResponse : RestApiResponse
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
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/driveitem-restore?view=graph-rest-1.0
        /// </summary>
        public async Task<DriveitemRestoreResponse> DriveitemRestoreAsync()
        {
            var p = new DriveitemRestoreParameter();
            return await this.SendAsync<DriveitemRestoreParameter, DriveitemRestoreResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/driveitem-restore?view=graph-rest-1.0
        /// </summary>
        public async Task<DriveitemRestoreResponse> DriveitemRestoreAsync(CancellationToken cancellationToken)
        {
            var p = new DriveitemRestoreParameter();
            return await this.SendAsync<DriveitemRestoreParameter, DriveitemRestoreResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/driveitem-restore?view=graph-rest-1.0
        /// </summary>
        public async Task<DriveitemRestoreResponse> DriveitemRestoreAsync(DriveitemRestoreParameter parameter)
        {
            return await this.SendAsync<DriveitemRestoreParameter, DriveitemRestoreResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/driveitem-restore?view=graph-rest-1.0
        /// </summary>
        public async Task<DriveitemRestoreResponse> DriveitemRestoreAsync(DriveitemRestoreParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<DriveitemRestoreParameter, DriveitemRestoreResponse>(parameter, cancellationToken);
        }
    }
}
