﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/event-list-instances?view=graph-rest-1.0
    /// </summary>
    public partial class EventListInstancesParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? Id { get; set; }
            public string? IdOrUserPrincipalName { get; set; }
            public string? GroupsId { get; set; }
            public string? EventsId { get; set; }
            public string? CalendarsId { get; set; }
            public string? UsersIdOrUserPrincipalName { get; set; }
            public string? CalendarGroupsId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Me_Events_Id_Instances: return $"/me/events/{Id}/instances";
                    case ApiPath.Users_IdOrUserPrincipalName_Events_Id_Instances: return $"/users/{IdOrUserPrincipalName}/events/{Id}/instances";
                    case ApiPath.Groups_Id_Events_Id_Instances: return $"/groups/{GroupsId}/events/{EventsId}/instances";
                    case ApiPath.Me_Calendar_Events_Id_Instances: return $"/me/calendar/events/{Id}/instances";
                    case ApiPath.Users_IdOrUserPrincipalName_Calendar_Events_Id_Instances: return $"/users/{IdOrUserPrincipalName}/calendar/events/{Id}/instances";
                    case ApiPath.Groups_Id_Calendar_Events_Id_Instances: return $"/groups/{GroupsId}/calendar/events/{EventsId}/instances";
                    case ApiPath.Me_Calendars_Id_Events_Id_Instances: return $"/me/calendars/{CalendarsId}/events/{EventsId}/instances";
                    case ApiPath.Users_IdOrUserPrincipalName_Calendars_Id_Events_Id_Instances: return $"/users/{UsersIdOrUserPrincipalName}/calendars/{CalendarsId}/events/{EventsId}/instances";
                    case ApiPath.Me_CalendarGroups_Id_Calendars_Id_Events_Id_Instances: return $"/me/calendarGroups/{CalendarGroupsId}/calendars/{CalendarsId}/events/{EventsId}/instances";
                    case ApiPath.Users_IdOrUserPrincipalName_CalendarGroups_Id_Calendars_Id_Events_Id_Instances: return $"/users/{UsersIdOrUserPrincipalName}/calendarGroups/{CalendarGroupsId}/calendars/{CalendarsId}/events/{EventsId}/instances";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
            AllowNewTimeProposals,
            Attendees,
            Body,
            BodyPreview,
            Categories,
            ChangeKey,
            CreatedDateTime,
            End,
            HasAttachments,
            HideAttendees,
            ICalUId,
            Id,
            Importance,
            IsAllDay,
            IsCancelled,
            IsDraft,
            IsOnlineMeeting,
            IsOrganizer,
            IsReminderOn,
            LastModifiedDateTime,
            Location,
            Locations,
            OnlineMeeting,
            OnlineMeetingProvider,
            OnlineMeetingUrl,
            Organizer,
            OriginalEndTimeZone,
            OriginalStart,
            OriginalStartTimeZone,
            Recurrence,
            ReminderMinutesBeforeStart,
            ResponseRequested,
            ResponseStatus,
            Sensitivity,
            SeriesMasterId,
            ShowAs,
            Start,
            Subject,
            TransactionId,
            Type,
            WebLink,
            Attachments,
            Calendar,
            Extensions,
            Instances,
            MultiValueExtendedProperties,
            SingleValueExtendedProperties,
        }
        public enum ApiPath
        {
            Me_Events_Id_Instances,
            Users_IdOrUserPrincipalName_Events_Id_Instances,
            Groups_Id_Events_Id_Instances,
            Me_Calendar_Events_Id_Instances,
            Users_IdOrUserPrincipalName_Calendar_Events_Id_Instances,
            Groups_Id_Calendar_Events_Id_Instances,
            Me_Calendars_Id_Events_Id_Instances,
            Users_IdOrUserPrincipalName_Calendars_Id_Events_Id_Instances,
            Me_CalendarGroups_Id_Calendars_Id_Events_Id_Instances,
            Users_IdOrUserPrincipalName_CalendarGroups_Id_Calendars_Id_Events_Id_Instances,
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
    public partial class EventListInstancesResponse : RestApiResponse
    {
        public Event[]? Value { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/event-list-instances?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/event-list-instances?view=graph-rest-1.0
        /// </summary>
        public async Task<EventListInstancesResponse> EventListInstancesAsync()
        {
            var p = new EventListInstancesParameter();
            return await this.SendAsync<EventListInstancesParameter, EventListInstancesResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/event-list-instances?view=graph-rest-1.0
        /// </summary>
        public async Task<EventListInstancesResponse> EventListInstancesAsync(CancellationToken cancellationToken)
        {
            var p = new EventListInstancesParameter();
            return await this.SendAsync<EventListInstancesParameter, EventListInstancesResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/event-list-instances?view=graph-rest-1.0
        /// </summary>
        public async Task<EventListInstancesResponse> EventListInstancesAsync(EventListInstancesParameter parameter)
        {
            return await this.SendAsync<EventListInstancesParameter, EventListInstancesResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/event-list-instances?view=graph-rest-1.0
        /// </summary>
        public async Task<EventListInstancesResponse> EventListInstancesAsync(EventListInstancesParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<EventListInstancesParameter, EventListInstancesResponse>(parameter, cancellationToken);
        }
    }
}
