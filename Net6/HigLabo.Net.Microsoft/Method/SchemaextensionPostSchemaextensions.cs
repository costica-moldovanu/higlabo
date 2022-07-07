﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class SchemaextensionPostSchemaextensionsParameter : IRestApiParameter
    {
        public enum ApiPath
        {
            SchemaExtensions,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.SchemaExtensions: return $"/schemaExtensions";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string? Description { get; set; }
        public string? Id { get; set; }
        public string? Owner { get; set; }
        public ExtensionSchemaProperty[]? Properties { get; set; }
        public String[]? TargetTypes { get; set; }
    }
    public partial class SchemaextensionPostSchemaextensionsResponse : RestApiResponse
    {
        public string? Description { get; set; }
        public string? Id { get; set; }
        public string? Owner { get; set; }
        public ExtensionSchemaProperty[]? Properties { get; set; }
        public string? Status { get; set; }
        public String[]? TargetTypes { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/schemaextension-post-schemaextensions?view=graph-rest-1.0
        /// </summary>
        public async Task<SchemaextensionPostSchemaextensionsResponse> SchemaextensionPostSchemaextensionsAsync()
        {
            var p = new SchemaextensionPostSchemaextensionsParameter();
            return await this.SendAsync<SchemaextensionPostSchemaextensionsParameter, SchemaextensionPostSchemaextensionsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/schemaextension-post-schemaextensions?view=graph-rest-1.0
        /// </summary>
        public async Task<SchemaextensionPostSchemaextensionsResponse> SchemaextensionPostSchemaextensionsAsync(CancellationToken cancellationToken)
        {
            var p = new SchemaextensionPostSchemaextensionsParameter();
            return await this.SendAsync<SchemaextensionPostSchemaextensionsParameter, SchemaextensionPostSchemaextensionsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/schemaextension-post-schemaextensions?view=graph-rest-1.0
        /// </summary>
        public async Task<SchemaextensionPostSchemaextensionsResponse> SchemaextensionPostSchemaextensionsAsync(SchemaextensionPostSchemaextensionsParameter parameter)
        {
            return await this.SendAsync<SchemaextensionPostSchemaextensionsParameter, SchemaextensionPostSchemaextensionsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/schemaextension-post-schemaextensions?view=graph-rest-1.0
        /// </summary>
        public async Task<SchemaextensionPostSchemaextensionsResponse> SchemaextensionPostSchemaextensionsAsync(SchemaextensionPostSchemaextensionsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<SchemaextensionPostSchemaextensionsParameter, SchemaextensionPostSchemaextensionsResponse>(parameter, cancellationToken);
        }
    }
}
