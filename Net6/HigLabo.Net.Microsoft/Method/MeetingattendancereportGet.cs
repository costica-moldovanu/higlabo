﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class MeetingattendancereportGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
        }
        public enum ApiPath
        {
            Me_OnlineMeetings_MeetingId_AttendanceReports_ReportId,
            Users_UserId_OnlineMeetings_MeetingId_AttendanceReports_ReportId,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Me_OnlineMeetings_MeetingId_AttendanceReports_ReportId: return $"/me/onlineMeetings/{MeetingId}/attendanceReports/{ReportId}";
                    case ApiPath.Users_UserId_OnlineMeetings_MeetingId_AttendanceReports_ReportId: return $"/users/{UserId}/onlineMeetings/{MeetingId}/attendanceReports/{ReportId}";
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
        public string MeetingId { get; set; }
        public string ReportId { get; set; }
        public string UserId { get; set; }
    }
    public partial class MeetingattendancereportGetResponse : RestApiResponse
    {
        public string? Id { get; set; }
        public DateTimeOffset? MeetingEndDateTime { get; set; }
        public DateTimeOffset? MeetingStartDateTime { get; set; }
        public Int32? TotalParticipantCount { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/meetingattendancereport-get?view=graph-rest-1.0
        /// </summary>
        public async Task<MeetingattendancereportGetResponse> MeetingattendancereportGetAsync()
        {
            var p = new MeetingattendancereportGetParameter();
            return await this.SendAsync<MeetingattendancereportGetParameter, MeetingattendancereportGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/meetingattendancereport-get?view=graph-rest-1.0
        /// </summary>
        public async Task<MeetingattendancereportGetResponse> MeetingattendancereportGetAsync(CancellationToken cancellationToken)
        {
            var p = new MeetingattendancereportGetParameter();
            return await this.SendAsync<MeetingattendancereportGetParameter, MeetingattendancereportGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/meetingattendancereport-get?view=graph-rest-1.0
        /// </summary>
        public async Task<MeetingattendancereportGetResponse> MeetingattendancereportGetAsync(MeetingattendancereportGetParameter parameter)
        {
            return await this.SendAsync<MeetingattendancereportGetParameter, MeetingattendancereportGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/meetingattendancereport-get?view=graph-rest-1.0
        /// </summary>
        public async Task<MeetingattendancereportGetResponse> MeetingattendancereportGetAsync(MeetingattendancereportGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<MeetingattendancereportGetParameter, MeetingattendancereportGetResponse>(parameter, cancellationToken);
        }
    }
}
