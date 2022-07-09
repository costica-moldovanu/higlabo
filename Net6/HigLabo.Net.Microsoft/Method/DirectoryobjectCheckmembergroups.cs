﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class DirectoryobjectCheckmemberGroupsParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? Id { get; set; }
            public string? IdOrUserPrincipalName { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.DirectoryObjects_Id_CheckMemberGroups: return $"/directoryObjects/{Id}/checkMemberGroups";
                    case ApiPath.Me_CheckMemberGroups: return $"/me/checkMemberGroups";
                    case ApiPath.Users_IdOrUserPrincipalName_CheckMemberGroups: return $"/users/{IdOrUserPrincipalName}/checkMemberGroups";
                    case ApiPath.Groups_Id_CheckMemberGroups: return $"/groups/{Id}/checkMemberGroups";
                    case ApiPath.ServicePrincipals_Id_CheckMemberGroups: return $"/servicePrincipals/{Id}/checkMemberGroups";
                    case ApiPath.Contacts_Id_CheckMemberGroups: return $"/contacts/{Id}/checkMemberGroups";
                    case ApiPath.Devices_Id_CheckMemberGroups: return $"/devices/{Id}/checkMemberGroups";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            DirectoryObjects_Id_CheckMemberGroups,
            Me_CheckMemberGroups,
            Users_IdOrUserPrincipalName_CheckMemberGroups,
            Groups_Id_CheckMemberGroups,
            ServicePrincipals_Id_CheckMemberGroups,
            Contacts_Id_CheckMemberGroups,
            Devices_Id_CheckMemberGroups,
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
        public String[]? GroupIds { get; set; }
    }
    public partial class DirectoryobjectCheckmemberGroupsResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/directoryobject-checkmembergroups?view=graph-rest-1.0
        /// </summary>
        public async Task<DirectoryobjectCheckmemberGroupsResponse> DirectoryobjectCheckmemberGroupsAsync()
        {
            var p = new DirectoryobjectCheckmemberGroupsParameter();
            return await this.SendAsync<DirectoryobjectCheckmemberGroupsParameter, DirectoryobjectCheckmemberGroupsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/directoryobject-checkmembergroups?view=graph-rest-1.0
        /// </summary>
        public async Task<DirectoryobjectCheckmemberGroupsResponse> DirectoryobjectCheckmemberGroupsAsync(CancellationToken cancellationToken)
        {
            var p = new DirectoryobjectCheckmemberGroupsParameter();
            return await this.SendAsync<DirectoryobjectCheckmemberGroupsParameter, DirectoryobjectCheckmemberGroupsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/directoryobject-checkmembergroups?view=graph-rest-1.0
        /// </summary>
        public async Task<DirectoryobjectCheckmemberGroupsResponse> DirectoryobjectCheckmemberGroupsAsync(DirectoryobjectCheckmemberGroupsParameter parameter)
        {
            return await this.SendAsync<DirectoryobjectCheckmemberGroupsParameter, DirectoryobjectCheckmemberGroupsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/directoryobject-checkmembergroups?view=graph-rest-1.0
        /// </summary>
        public async Task<DirectoryobjectCheckmemberGroupsResponse> DirectoryobjectCheckmemberGroupsAsync(DirectoryobjectCheckmemberGroupsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<DirectoryobjectCheckmemberGroupsParameter, DirectoryobjectCheckmemberGroupsResponse>(parameter, cancellationToken);
        }
    }
}
