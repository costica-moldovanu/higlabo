﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class PresenceClearpresenceParameter : IRestApiParameter
    {
        public enum ApiPath
        {
            Users_UserId_Presence_ClearPresence,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Users_UserId_Presence_ClearPresence: return $"/users/{UserId}/presence/clearPresence";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string? SessionId { get; set; }
        public string UserId { get; set; }
    }
    public partial class PresenceClearpresenceResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/presence-clearpresence?view=graph-rest-1.0
        /// </summary>
        public async Task<PresenceClearpresenceResponse> PresenceClearpresenceAsync()
        {
            var p = new PresenceClearpresenceParameter();
            return await this.SendAsync<PresenceClearpresenceParameter, PresenceClearpresenceResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/presence-clearpresence?view=graph-rest-1.0
        /// </summary>
        public async Task<PresenceClearpresenceResponse> PresenceClearpresenceAsync(CancellationToken cancellationToken)
        {
            var p = new PresenceClearpresenceParameter();
            return await this.SendAsync<PresenceClearpresenceParameter, PresenceClearpresenceResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/presence-clearpresence?view=graph-rest-1.0
        /// </summary>
        public async Task<PresenceClearpresenceResponse> PresenceClearpresenceAsync(PresenceClearpresenceParameter parameter)
        {
            return await this.SendAsync<PresenceClearpresenceParameter, PresenceClearpresenceResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/presence-clearpresence?view=graph-rest-1.0
        /// </summary>
        public async Task<PresenceClearpresenceResponse> PresenceClearpresenceAsync(PresenceClearpresenceParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<PresenceClearpresenceParameter, PresenceClearpresenceResponse>(parameter, cancellationToken);
        }
    }
}
