﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class SubjectrightsrequestGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? SubjectRightsRequestId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Privacy_SubjectRightsRequests_SubjectRightsRequestId: return $"/privacy/subjectRightsRequests/{SubjectRightsRequestId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Privacy_SubjectRightsRequests_SubjectRightsRequestId,
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
    public partial class SubjectrightsrequestGetResponse : RestApiResponse
    {
        public enum SubjectRightsRequestDataSubjectType
        {
            Customer,
            CurrentEmployee,
            FormerEmployee,
            ProspectiveEmployee,
            Student,
            Teacher,
            Faculty,
            Other,
            UnknownFutureValue,
        }
        public enum SubjectRightsRequestSubjectRightsRequestStatus
        {
            Active,
            Closed,
            UnknownFutureValue,
        }
        public enum SubjectRightsRequestSubjectRightsRequestType
        {
            Export,
            Delete,
            Access,
            TagForAction,
            UnknownFutureValue,
        }

        public Identity? AssignedTo { get; set; }
        public DateTimeOffset? ClosedDateTime { get; set; }
        public IdentitySet? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public DataSubject? DataSubject { get; set; }
        public SubjectRightsRequestDataSubjectType DataSubjectType { get; set; }
        public string? Description { get; set; }
        public string? DisplayName { get; set; }
        public SubjectRightsRequestHistory[]? History { get; set; }
        public SubjectRightsRequestDetail? Insight { get; set; }
        public DateTimeOffset? InternalDueDateTime { get; set; }
        public IdentitySet? LastModifiedBy { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public String[]? Regulations { get; set; }
        public SubjectRightsRequestStageDetail[]? Stages { get; set; }
        public SubjectRightsRequestSubjectRightsRequestStatus Status { get; set; }
        public SubjectRightsRequestSubjectRightsRequestType Type { get; set; }
        public AuthoredNote[]? Notes { get; set; }
        public Team? Team { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/subjectrightsrequest-get?view=graph-rest-1.0
        /// </summary>
        public async Task<SubjectrightsrequestGetResponse> SubjectrightsrequestGetAsync()
        {
            var p = new SubjectrightsrequestGetParameter();
            return await this.SendAsync<SubjectrightsrequestGetParameter, SubjectrightsrequestGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/subjectrightsrequest-get?view=graph-rest-1.0
        /// </summary>
        public async Task<SubjectrightsrequestGetResponse> SubjectrightsrequestGetAsync(CancellationToken cancellationToken)
        {
            var p = new SubjectrightsrequestGetParameter();
            return await this.SendAsync<SubjectrightsrequestGetParameter, SubjectrightsrequestGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/subjectrightsrequest-get?view=graph-rest-1.0
        /// </summary>
        public async Task<SubjectrightsrequestGetResponse> SubjectrightsrequestGetAsync(SubjectrightsrequestGetParameter parameter)
        {
            return await this.SendAsync<SubjectrightsrequestGetParameter, SubjectrightsrequestGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/subjectrightsrequest-get?view=graph-rest-1.0
        /// </summary>
        public async Task<SubjectrightsrequestGetResponse> SubjectrightsrequestGetAsync(SubjectrightsrequestGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<SubjectrightsrequestGetParameter, SubjectrightsrequestGetResponse>(parameter, cancellationToken);
        }
    }
}
