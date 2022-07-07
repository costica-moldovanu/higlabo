﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class SiteUnfollowParameter : IRestApiParameter
    {
        public enum ApiPath
        {
            Users_UserId_FollowedSites_Remove,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Users_UserId_FollowedSites_Remove: return $"/users/{UserId}/followedSites/remove";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string? Id { get; set; }
        public string UserId { get; set; }
    }
    public partial class SiteUnfollowResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/site-unfollow?view=graph-rest-1.0
        /// </summary>
        public async Task<SiteUnfollowResponse> SiteUnfollowAsync()
        {
            var p = new SiteUnfollowParameter();
            return await this.SendAsync<SiteUnfollowParameter, SiteUnfollowResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/site-unfollow?view=graph-rest-1.0
        /// </summary>
        public async Task<SiteUnfollowResponse> SiteUnfollowAsync(CancellationToken cancellationToken)
        {
            var p = new SiteUnfollowParameter();
            return await this.SendAsync<SiteUnfollowParameter, SiteUnfollowResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/site-unfollow?view=graph-rest-1.0
        /// </summary>
        public async Task<SiteUnfollowResponse> SiteUnfollowAsync(SiteUnfollowParameter parameter)
        {
            return await this.SendAsync<SiteUnfollowParameter, SiteUnfollowResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/site-unfollow?view=graph-rest-1.0
        /// </summary>
        public async Task<SiteUnfollowResponse> SiteUnfollowAsync(SiteUnfollowParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<SiteUnfollowParameter, SiteUnfollowResponse>(parameter, cancellationToken);
        }
    }
}
