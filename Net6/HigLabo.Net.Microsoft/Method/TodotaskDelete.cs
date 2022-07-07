﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class TodotaskDeleteParameter : IRestApiParameter
    {
        public enum ApiPath
        {
            Me_Todo_Lists_TodoTaskListId_Tasks_TaskId,
            Users_IdOruserPrincipalName_Todo_Lists_TodoTaskListId_Tasks_TaskId,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Me_Todo_Lists_TodoTaskListId_Tasks_TaskId: return $"/me/todo/lists/{TodoTaskListId}/tasks/{TaskId}";
                    case ApiPath.Users_IdOruserPrincipalName_Todo_Lists_TodoTaskListId_Tasks_TaskId: return $"/users/{IdOrUserPrincipalName}/todo/lists/{TodoTaskListId}/tasks/{TaskId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "DELETE";
        public string TodoTaskListId { get; set; }
        public string TaskId { get; set; }
        public string IdOrUserPrincipalName { get; set; }
    }
    public partial class TodotaskDeleteResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/todotask-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<TodotaskDeleteResponse> TodotaskDeleteAsync()
        {
            var p = new TodotaskDeleteParameter();
            return await this.SendAsync<TodotaskDeleteParameter, TodotaskDeleteResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/todotask-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<TodotaskDeleteResponse> TodotaskDeleteAsync(CancellationToken cancellationToken)
        {
            var p = new TodotaskDeleteParameter();
            return await this.SendAsync<TodotaskDeleteParameter, TodotaskDeleteResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/todotask-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<TodotaskDeleteResponse> TodotaskDeleteAsync(TodotaskDeleteParameter parameter)
        {
            return await this.SendAsync<TodotaskDeleteParameter, TodotaskDeleteResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/todotask-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<TodotaskDeleteResponse> TodotaskDeleteAsync(TodotaskDeleteParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<TodotaskDeleteParameter, TodotaskDeleteResponse>(parameter, cancellationToken);
        }
    }
}
