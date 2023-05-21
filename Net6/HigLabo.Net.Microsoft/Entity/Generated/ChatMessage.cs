﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/resources/chatmessage?view=graph-rest-1.0
    /// </summary>
    public partial class ChatMessage
    {
        public enum ChatMessagestring
        {
            Normal,
            High,
            Urgent,
        }
        public enum ChatMessageChatMessageType
        {
            Message,
            ChatEvent,
            Typing,
            UnknownFutureValue,
            SystemEventMessage,
        }

        public ChatMessageAttachment[]? Attachments { get; set; }
        public ItemBody? Body { get; set; }
        public string? ChatId { get; set; }
        public ChannelIdentity? ChannelIdentity { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public DateTimeOffset? DeletedDateTime { get; set; }
        public string? Etag { get; set; }
        public EventMessageDetail? EventDetail { get; set; }
        public ChatMessageFromIdentitySet? From { get; set; }
        public string? Id { get; set; }
        public ChatMessagestring Importance { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public DateTimeOffset? LastEditedDateTime { get; set; }
        public string? Locale { get; set; }
        public ChatMessageMention[]? Mentions { get; set; }
        public ChatMessageHistoryItem[]? MessageHistory { get; set; }
        public ChatMessageChatMessageType MessageType { get; set; }
        public ChatMessagePolicyViolation? PolicyViolation { get; set; }
        public ChatMessageReAction[]? Reactions { get; set; }
        public string? ReplyToId { get; set; }
        public string? Subject { get; set; }
        public string? Summary { get; set; }
        public string? WebUrl { get; set; }
        public ChatMessageHostedContent? HostedContents { get; set; }
        public ChatMessage? Replies { get; set; }
    }
}
