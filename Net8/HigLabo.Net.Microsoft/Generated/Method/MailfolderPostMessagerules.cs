﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/mailfolder-post-messagerules?view=graph-rest-1.0
    /// </summary>
    public partial class MailfolderPostMessagerulesParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? IdOrUserPrincipalName { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Me_MailFolders_Inbox_MessageRules: return $"/me/mailFolders/inbox/messageRules";
                    case ApiPath.Users_IdOrUserPrincipalName_MailFolders_Inbox_MessageRules: return $"/users/{IdOrUserPrincipalName}/mailFolders/inbox/messageRules";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Me_MailFolders_Inbox_MessageRules,
            Users_IdOrUserPrincipalName_MailFolders_Inbox_MessageRules,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public MessageRuleActions? Actions { get; set; }
        public MessageRulePredicates? Conditions { get; set; }
        public string? DisplayName { get; set; }
        public MessageRulePredicates? Exceptions { get; set; }
        public bool? IsEnabled { get; set; }
        public Int32? Sequence { get; set; }
    }
    public partial class MailfolderPostMessagerulesResponse : RestApiResponse
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/mailfolder-post-messagerules?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/mailfolder-post-messagerules?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<MailfolderPostMessagerulesResponse> MailfolderPostMessagerulesAsync()
        {
            var p = new MailfolderPostMessagerulesParameter();
            return await this.SendAsync<MailfolderPostMessagerulesParameter, MailfolderPostMessagerulesResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/mailfolder-post-messagerules?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<MailfolderPostMessagerulesResponse> MailfolderPostMessagerulesAsync(CancellationToken cancellationToken)
        {
            var p = new MailfolderPostMessagerulesParameter();
            return await this.SendAsync<MailfolderPostMessagerulesParameter, MailfolderPostMessagerulesResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/mailfolder-post-messagerules?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<MailfolderPostMessagerulesResponse> MailfolderPostMessagerulesAsync(MailfolderPostMessagerulesParameter parameter)
        {
            return await this.SendAsync<MailfolderPostMessagerulesParameter, MailfolderPostMessagerulesResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/mailfolder-post-messagerules?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<MailfolderPostMessagerulesResponse> MailfolderPostMessagerulesAsync(MailfolderPostMessagerulesParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<MailfolderPostMessagerulesParameter, MailfolderPostMessagerulesResponse>(parameter, cancellationToken);
        }
    }
}
