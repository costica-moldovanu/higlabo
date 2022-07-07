﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class MessageReplyParameter : IRestApiParameter
    {
        public enum ApiPath
        {
            Me_Messages_Id_Reply,
            Users_IdOrUserPrincipalName_Messages_Id_Reply,
            Me_MailFolders_Id_Messages_Id_Reply,
            Users_IdOrUserPrincipalName_MailFolders_Id_Messages_Id_Reply,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Me_Messages_Id_Reply: return $"/me/messages/{Id}/reply";
                    case ApiPath.Users_IdOrUserPrincipalName_Messages_Id_Reply: return $"/users/{IdOrUserPrincipalName}/messages/{Id}/reply";
                    case ApiPath.Me_MailFolders_Id_Messages_Id_Reply: return $"/me/mailFolders/{MailFoldersId}/messages/{MessagesId}/reply";
                    case ApiPath.Users_IdOrUserPrincipalName_MailFolders_Id_Messages_Id_Reply: return $"/users/{UsersIdOrUserPrincipalName}/mailFolders/{MailFoldersId}/messages/{MessagesId}/reply";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string? Comment { get; set; }
        public Message? Message { get; set; }
        public string Id { get; set; }
        public string IdOrUserPrincipalName { get; set; }
        public string MailFoldersId { get; set; }
        public string MessagesId { get; set; }
        public string UsersIdOrUserPrincipalName { get; set; }
    }
    public partial class MessageReplyResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/message-reply?view=graph-rest-1.0
        /// </summary>
        public async Task<MessageReplyResponse> MessageReplyAsync()
        {
            var p = new MessageReplyParameter();
            return await this.SendAsync<MessageReplyParameter, MessageReplyResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/message-reply?view=graph-rest-1.0
        /// </summary>
        public async Task<MessageReplyResponse> MessageReplyAsync(CancellationToken cancellationToken)
        {
            var p = new MessageReplyParameter();
            return await this.SendAsync<MessageReplyParameter, MessageReplyResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/message-reply?view=graph-rest-1.0
        /// </summary>
        public async Task<MessageReplyResponse> MessageReplyAsync(MessageReplyParameter parameter)
        {
            return await this.SendAsync<MessageReplyParameter, MessageReplyResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/message-reply?view=graph-rest-1.0
        /// </summary>
        public async Task<MessageReplyResponse> MessageReplyAsync(MessageReplyParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<MessageReplyParameter, MessageReplyResponse>(parameter, cancellationToken);
        }
    }
}
