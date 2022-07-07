﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class AttachmentDeleteParameter : IRestApiParameter
    {
        public enum ApiPath
        {
            Me_Events_Id_Attachments_Id,
            Users_IdOrUserPrincipalName_Events_Id_Attachments_Id,
            Me_Calendar_Events_Id_Attachments_Id,
            Users_IdOrUserPrincipalName_Calendar_Events_Id_Attachments_Id,
            Me_Calendars_Id_Events_Id_Attachments_Id,
            Users_IdOrUserPrincipalName_Calendars_Id_Events_Id_Attachments_Id,
            Me_Calendargroups_Id_Calendars_Id_Events_Id_Attachments_Id,
            Users_IdOrUserPrincipalName_Calendargroups_Id_Calendars_Id_Events_Id_Attachments_Id,
            Me_Messages_Id_Attachments_Id,
            Users_IdOrUserPrincipalName_Messages_Id_Attachments_Id,
            Me_MailFolders_Id_Messages_Id_Attachments_Id,
            Users_IdOrUserPrincipalName_MailFolders_Id_Messages_Id_Attachments_Id,
            Me_MailFolders_Id_ChildFolders_Id__Messages_Id_Attachments_Id,
            Users_IdOrUserPrincipalName_MailFolders_Id_ChildFolders_Id_Messages_Id_Attachments_Id,
            Groups_Id_Threads_Id_Posts_Id_Attachments_Id,
            Groups_Id_Conversations_Id_Threads_Id_Posts_Id_Attachments_Id,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Me_Events_Id_Attachments_Id: return $"/me/events/{EventsId}/attachments/{AttachmentsId}";
                    case ApiPath.Users_IdOrUserPrincipalName_Events_Id_Attachments_Id: return $"/users/{UsersIdOrUserPrincipalName}/events/{EventsId}/attachments/{AttachmentsId}";
                    case ApiPath.Me_Calendar_Events_Id_Attachments_Id: return $"/me/calendar/events/{EventsId}/attachments/{AttachmentsId}";
                    case ApiPath.Users_IdOrUserPrincipalName_Calendar_Events_Id_Attachments_Id: return $"/users/{UsersIdOrUserPrincipalName}/calendar/events/{EventsId}/attachments/{AttachmentsId}";
                    case ApiPath.Me_Calendars_Id_Events_Id_Attachments_Id: return $"/me/calendars/{CalendarsId}/events/{EventsId}/attachments/{AttachmentsId}";
                    case ApiPath.Users_IdOrUserPrincipalName_Calendars_Id_Events_Id_Attachments_Id: return $"/users/{UsersIdOrUserPrincipalName}/calendars/{CalendarsId}/events/{EventsId}/attachments/{AttachmentsId}";
                    case ApiPath.Me_Calendargroups_Id_Calendars_Id_Events_Id_Attachments_Id: return $"/me/calendargroups/{CalendargroupsId}/calendars/{CalendarsId}/events/{EventsId}/attachments/{AttachmentsId}";
                    case ApiPath.Users_IdOrUserPrincipalName_Calendargroups_Id_Calendars_Id_Events_Id_Attachments_Id: return $"/users/{UsersIdOrUserPrincipalName}/calendargroups/{CalendargroupsId}/calendars/{CalendarsId}/events/{EventsId}/attachments/{AttachmentsId}";
                    case ApiPath.Me_Messages_Id_Attachments_Id: return $"/me/messages/{MessagesId}/attachments/{AttachmentsId}";
                    case ApiPath.Users_IdOrUserPrincipalName_Messages_Id_Attachments_Id: return $"/users/{UsersIdOrUserPrincipalName}/messages/{MessagesId}/attachments/{AttachmentsId}";
                    case ApiPath.Me_MailFolders_Id_Messages_Id_Attachments_Id: return $"/me/mailFolders/{MailFoldersId}/messages/{MessagesId}/attachments/{AttachmentsId}";
                    case ApiPath.Users_IdOrUserPrincipalName_MailFolders_Id_Messages_Id_Attachments_Id: return $"/users/{UsersIdOrUserPrincipalName}/mailFolders/{MailFoldersId}/messages/{MessagesId}/attachments/{AttachmentsId}";
                    case ApiPath.Me_MailFolders_Id_ChildFolders_Id__Messages_Id_Attachments_Id: return $"/me/mailFolders/{MailFoldersId}/childFolders/{ChildFoldersId}/.../messages/{MessagesId}/attachments/{AttachmentsId}";
                    case ApiPath.Users_IdOrUserPrincipalName_MailFolders_Id_ChildFolders_Id_Messages_Id_Attachments_Id: return $"/users/{UsersIdOrUserPrincipalName}/mailFolders/{MailFoldersId}/childFolders/{ChildFoldersId}/messages/{MessagesId}/attachments/{AttachmentsId}";
                    case ApiPath.Groups_Id_Threads_Id_Posts_Id_Attachments_Id: return $"/groups/{GroupsId}/threads/{ThreadsId}/posts/{PostsId}/attachments/{AttachmentsId}";
                    case ApiPath.Groups_Id_Conversations_Id_Threads_Id_Posts_Id_Attachments_Id: return $"/groups/{GroupsId}/conversations/{ConversationsId}/threads/{ThreadsId}/posts/{PostsId}/attachments/{AttachmentsId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "DELETE";
        public string EventsId { get; set; }
        public string AttachmentsId { get; set; }
        public string UsersIdOrUserPrincipalName { get; set; }
        public string CalendarsId { get; set; }
        public string CalendargroupsId { get; set; }
        public string MessagesId { get; set; }
        public string MailFoldersId { get; set; }
        public string ChildFoldersId { get; set; }
        public string GroupsId { get; set; }
        public string ThreadsId { get; set; }
        public string PostsId { get; set; }
        public string ConversationsId { get; set; }
    }
    public partial class AttachmentDeleteResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/attachment-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<AttachmentDeleteResponse> AttachmentDeleteAsync()
        {
            var p = new AttachmentDeleteParameter();
            return await this.SendAsync<AttachmentDeleteParameter, AttachmentDeleteResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/attachment-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<AttachmentDeleteResponse> AttachmentDeleteAsync(CancellationToken cancellationToken)
        {
            var p = new AttachmentDeleteParameter();
            return await this.SendAsync<AttachmentDeleteParameter, AttachmentDeleteResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/attachment-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<AttachmentDeleteResponse> AttachmentDeleteAsync(AttachmentDeleteParameter parameter)
        {
            return await this.SendAsync<AttachmentDeleteParameter, AttachmentDeleteResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/attachment-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<AttachmentDeleteResponse> AttachmentDeleteAsync(AttachmentDeleteParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<AttachmentDeleteParameter, AttachmentDeleteResponse>(parameter, cancellationToken);
        }
    }
}
