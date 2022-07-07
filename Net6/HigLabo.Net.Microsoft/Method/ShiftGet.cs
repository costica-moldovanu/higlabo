﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class ShiftGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
            Id,
            UserId,
            SchedulingGroupId,
            SharedShift,
            DraftShift,
            CreatedDateTime,
            LastModifiedDateTime,
            LastModifiedBy,
        }
        public enum ApiPath
        {
            Teams_TeamId_Schedule_Shifts_ShiftId,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Teams_TeamId_Schedule_Shifts_ShiftId: return $"/teams/{TeamId}/schedule/shifts/{ShiftId}";
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
        public string TeamId { get; set; }
        public string ShiftId { get; set; }
    }
    public partial class ShiftGetResponse : RestApiResponse
    {
        public string? Id { get; set; }
        public string? UserId { get; set; }
        public string? SchedulingGroupId { get; set; }
        public ShiftItem? SharedShift { get; set; }
        public ShiftItem? DraftShift { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public IdentitySet? LastModifiedBy { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/shift-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ShiftGetResponse> ShiftGetAsync()
        {
            var p = new ShiftGetParameter();
            return await this.SendAsync<ShiftGetParameter, ShiftGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/shift-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ShiftGetResponse> ShiftGetAsync(CancellationToken cancellationToken)
        {
            var p = new ShiftGetParameter();
            return await this.SendAsync<ShiftGetParameter, ShiftGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/shift-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ShiftGetResponse> ShiftGetAsync(ShiftGetParameter parameter)
        {
            return await this.SendAsync<ShiftGetParameter, ShiftGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/shift-get?view=graph-rest-1.0
        /// </summary>
        public async Task<ShiftGetResponse> ShiftGetAsync(ShiftGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ShiftGetParameter, ShiftGetResponse>(parameter, cancellationToken);
        }
    }
}
