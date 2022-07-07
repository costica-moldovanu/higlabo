﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class DriveGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
            CreatedBy,
            CreatedDateTime,
            Description,
            DriveType,
            Id,
            LastModifiedBy,
            LastModifiedDateTime,
            Name,
            Owner,
            Quota,
            SharepointIds,
            System,
            WebUrl,
        }
        public enum ApiPath
        {
            Me_Drive,
            Users_IdOrUserPrincipalName_Drive,
            Groups_GroupId_Drive,
            Sites_SiteId_Drive,
            Drives_DriveId,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Me_Drive: return $"/me/drive";
                    case ApiPath.Users_IdOrUserPrincipalName_Drive: return $"/users/{IdOrUserPrincipalName}/drive";
                    case ApiPath.Groups_GroupId_Drive: return $"/groups/{GroupId}/drive";
                    case ApiPath.Sites_SiteId_Drive: return $"/sites/{SiteId}/drive";
                    case ApiPath.Drives_DriveId: return $"/drives/{DriveId}";
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
        public string IdOrUserPrincipalName { get; set; }
        public string GroupId { get; set; }
        public string SiteId { get; set; }
        public string DriveId { get; set; }
    }
    public partial class DriveGetResponse : RestApiResponse
    {
        public IdentitySet? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? Description { get; set; }
        public string? DriveType { get; set; }
        public string? Id { get; set; }
        public IdentitySet? LastModifiedBy { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string? Name { get; set; }
        public IdentitySet? Owner { get; set; }
        public Quota? Quota { get; set; }
        public SharePointIds? SharepointIds { get; set; }
        public System? System { get; set; }
        public string? WebUrl { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/drive-get?view=graph-rest-1.0
        /// </summary>
        public async Task<DriveGetResponse> DriveGetAsync()
        {
            var p = new DriveGetParameter();
            return await this.SendAsync<DriveGetParameter, DriveGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/drive-get?view=graph-rest-1.0
        /// </summary>
        public async Task<DriveGetResponse> DriveGetAsync(CancellationToken cancellationToken)
        {
            var p = new DriveGetParameter();
            return await this.SendAsync<DriveGetParameter, DriveGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/drive-get?view=graph-rest-1.0
        /// </summary>
        public async Task<DriveGetResponse> DriveGetAsync(DriveGetParameter parameter)
        {
            return await this.SendAsync<DriveGetParameter, DriveGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/drive-get?view=graph-rest-1.0
        /// </summary>
        public async Task<DriveGetResponse> DriveGetAsync(DriveGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<DriveGetParameter, DriveGetResponse>(parameter, cancellationToken);
        }
    }
}
