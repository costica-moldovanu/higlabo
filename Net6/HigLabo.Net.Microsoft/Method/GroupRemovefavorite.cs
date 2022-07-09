﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class GroupRemovefavoriteParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? Id { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Groups_Id_RemoveFavorite: return $"/groups/{Id}/removeFavorite";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Groups_Id_RemoveFavorite,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
    }
    public partial class GroupRemovefavoriteResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/group-removefavorite?view=graph-rest-1.0
        /// </summary>
        public async Task<GroupRemovefavoriteResponse> GroupRemovefavoriteAsync()
        {
            var p = new GroupRemovefavoriteParameter();
            return await this.SendAsync<GroupRemovefavoriteParameter, GroupRemovefavoriteResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/group-removefavorite?view=graph-rest-1.0
        /// </summary>
        public async Task<GroupRemovefavoriteResponse> GroupRemovefavoriteAsync(CancellationToken cancellationToken)
        {
            var p = new GroupRemovefavoriteParameter();
            return await this.SendAsync<GroupRemovefavoriteParameter, GroupRemovefavoriteResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/group-removefavorite?view=graph-rest-1.0
        /// </summary>
        public async Task<GroupRemovefavoriteResponse> GroupRemovefavoriteAsync(GroupRemovefavoriteParameter parameter)
        {
            return await this.SendAsync<GroupRemovefavoriteParameter, GroupRemovefavoriteResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/group-removefavorite?view=graph-rest-1.0
        /// </summary>
        public async Task<GroupRemovefavoriteResponse> GroupRemovefavoriteAsync(GroupRemovefavoriteParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<GroupRemovefavoriteParameter, GroupRemovefavoriteResponse>(parameter, cancellationToken);
        }
    }
}
