﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class CallGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
            CallbackUri,
            CallChainId,
            CallRoutes,
            ChatInfo,
            Direction,
            Id,
            MediaConfig,
            MediaState,
            MeetingInfo,
            Transcription,
            MyParticipantId,
            RequestedModalities,
            ResultInfo,
            Source,
            State,
            Subject,
            Targets,
            ToneInfo,
            IncomingContext,
        }
        public enum ApiPath
        {
            Communications_Calls_Id,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Communications_Calls_Id: return $"/communications/calls/{Id}";
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
        public string Id { get; set; }
    }
    public partial class CallGetResponse : RestApiResponse
    {
        public enum CallCallDirection
        {
            Incoming,
            Outgoing,
        }
        public enum CallModality
        {
            Unknown,
            Audio,
            Video,
            VideoBasedScreenSharing,
            Data,
        }
        public enum CallCallState
        {
            Incoming,
            Establishing,
            Ringing,
            Established,
            Hold,
            Transferring,
            TransferAccepted,
            Redirecting,
            Terminating,
            Terminated,
        }

        public string? CallbackUri { get; set; }
        public string? CallChainId { get; set; }
        public CallRoute[]? CallRoutes { get; set; }
        public ChatInfo? ChatInfo { get; set; }
        public CallCallDirection Direction { get; set; }
        public string? Id { get; set; }
        public AppHostedMediaConfig? MediaConfig { get; set; }
        public CallMediaState? MediaState { get; set; }
        public OrganizerMeetingInfo? MeetingInfo { get; set; }
        public CallTranscriptionInfo? Transcription { get; set; }
        public string? MyParticipantId { get; set; }
        public CallModality RequestedModalities { get; set; }
        public ResultInfo? ResultInfo { get; set; }
        public ParticipantInfo? Source { get; set; }
        public CallCallState State { get; set; }
        public string? Subject { get; set; }
        public ParticipantInfo[]? Targets { get; set; }
        public ToneInfo? ToneInfo { get; set; }
        public IncomingContext? IncomingContext { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/call-get?view=graph-rest-1.0
        /// </summary>
        public async Task<CallGetResponse> CallGetAsync()
        {
            var p = new CallGetParameter();
            return await this.SendAsync<CallGetParameter, CallGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/call-get?view=graph-rest-1.0
        /// </summary>
        public async Task<CallGetResponse> CallGetAsync(CancellationToken cancellationToken)
        {
            var p = new CallGetParameter();
            return await this.SendAsync<CallGetParameter, CallGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/call-get?view=graph-rest-1.0
        /// </summary>
        public async Task<CallGetResponse> CallGetAsync(CallGetParameter parameter)
        {
            return await this.SendAsync<CallGetParameter, CallGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/call-get?view=graph-rest-1.0
        /// </summary>
        public async Task<CallGetResponse> CallGetAsync(CallGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<CallGetParameter, CallGetResponse>(parameter, cancellationToken);
        }
    }
}
