﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class TeamGetPrimarychannelParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? Id { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Teams_Id_PrimaryChannel: return $"/teams/{Id}/primaryChannel";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
            DisplayName,
            Description,
            Classification,
            Specialization,
            Visibility,
            FunSettings,
            GuestSettings,
            InternalId,
            IsArchived,
            MemberSettings,
            MessagingSettings,
            WebUrl,
            CreatedDateTime,
            Channels,
            InstalledApps,
            Members,
            Operations,
            PrimaryChannel,
            Schedule,
            Template,
        }
        public enum ApiPath
        {
            Teams_Id_PrimaryChannel,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
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
    }
    public partial class TeamGetPrimarychannelResponse : RestApiResponse
    {
        public enum ChannelChannelMembershipType
        {
            Standard,
            Private,
        }

        public string? Description { get; set; }
        public string? DisplayName { get; set; }
        public string? Id { get; set; }
        public bool? IsFavoriteByDefault { get; set; }
        public string? Email { get; set; }
        public string? WebUrl { get; set; }
        public ChannelChannelMembershipType MembershipType { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public ChatMessage[]? Messages { get; set; }
        public TeamsTab[]? Tabs { get; set; }
        public ConversationMember[]? Members { get; set; }
        public DriveItem? FilesFolder { get; set; }
        public TeamsASyncOperation[]? Operations { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-get-primarychannel?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamGetPrimarychannelResponse> TeamGetPrimarychannelAsync()
        {
            var p = new TeamGetPrimarychannelParameter();
            return await this.SendAsync<TeamGetPrimarychannelParameter, TeamGetPrimarychannelResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-get-primarychannel?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamGetPrimarychannelResponse> TeamGetPrimarychannelAsync(CancellationToken cancellationToken)
        {
            var p = new TeamGetPrimarychannelParameter();
            return await this.SendAsync<TeamGetPrimarychannelParameter, TeamGetPrimarychannelResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-get-primarychannel?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamGetPrimarychannelResponse> TeamGetPrimarychannelAsync(TeamGetPrimarychannelParameter parameter)
        {
            return await this.SendAsync<TeamGetPrimarychannelParameter, TeamGetPrimarychannelResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/team-get-primarychannel?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamGetPrimarychannelResponse> TeamGetPrimarychannelAsync(TeamGetPrimarychannelParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<TeamGetPrimarychannelParameter, TeamGetPrimarychannelResponse>(parameter, cancellationToken);
        }
    }
}
