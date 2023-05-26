﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/conditionalaccessroot-list-templates?view=graph-rest-1.0
    /// </summary>
    public partial class ConditionalAccessRootListTemplatesParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Identity_ConditionalAccess_Templates: return $"/identity/conditionalAccess/templates";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
            Description,
            Details,
            Id,
            Name,
            Scenarios,
        }
        public enum ApiPath
        {
            Identity_ConditionalAccess_Templates,
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
    public partial class ConditionalAccessRootListTemplatesResponse : RestApiResponse
    {
        public ConditionalAccessTemplate[]? Value { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/conditionalaccessroot-list-templates?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/conditionalaccessroot-list-templates?view=graph-rest-1.0
        /// </summary>
        public async Task<ConditionalAccessRootListTemplatesResponse> ConditionalAccessRootListTemplatesAsync()
        {
            var p = new ConditionalAccessRootListTemplatesParameter();
            return await this.SendAsync<ConditionalAccessRootListTemplatesParameter, ConditionalAccessRootListTemplatesResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/conditionalaccessroot-list-templates?view=graph-rest-1.0
        /// </summary>
        public async Task<ConditionalAccessRootListTemplatesResponse> ConditionalAccessRootListTemplatesAsync(CancellationToken cancellationToken)
        {
            var p = new ConditionalAccessRootListTemplatesParameter();
            return await this.SendAsync<ConditionalAccessRootListTemplatesParameter, ConditionalAccessRootListTemplatesResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/conditionalaccessroot-list-templates?view=graph-rest-1.0
        /// </summary>
        public async Task<ConditionalAccessRootListTemplatesResponse> ConditionalAccessRootListTemplatesAsync(ConditionalAccessRootListTemplatesParameter parameter)
        {
            return await this.SendAsync<ConditionalAccessRootListTemplatesParameter, ConditionalAccessRootListTemplatesResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/conditionalaccessroot-list-templates?view=graph-rest-1.0
        /// </summary>
        public async Task<ConditionalAccessRootListTemplatesResponse> ConditionalAccessRootListTemplatesAsync(ConditionalAccessRootListTemplatesParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ConditionalAccessRootListTemplatesParameter, ConditionalAccessRootListTemplatesResponse>(parameter, cancellationToken);
        }
    }
}
