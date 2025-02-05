﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HigLabo.OpenAI
{
    /// <summary>
    /// Retrieves a run.
    /// <seealso href="https://api.openai.com/v1/threads/{thread_id}/runs/{run_id}">https://api.openai.com/v1/threads/{thread_id}/runs/{run_id}</seealso>
    /// </summary>
    public partial class RunRetrieveParameter : RestApiParameter, IRestApiParameter
    {
        string IRestApiParameter.HttpMethod { get; } = "GET";
        /// <summary>
        /// The ID of the thread that was run.
        /// </summary>
        public string Thread_Id { get; set; } = "";
        /// <summary>
        /// The ID of the run to retrieve.
        /// </summary>
        public string Run_Id { get; set; } = "";

        string IRestApiParameter.GetApiPath()
        {
            return $"/threads/{Thread_Id}/runs/{Run_Id}";
        }
        public override object GetRequestBody()
        {
            return EmptyParameter;
        }
    }
    public partial class RunRetrieveResponse : RunObjectResponse
    {
    }
    public partial class OpenAIClient
    {
        public async ValueTask<RunRetrieveResponse> RunRetrieveAsync(string thread_Id, string run_Id)
        {
            var p = new RunRetrieveParameter();
            p.Thread_Id = thread_Id;
            p.Run_Id = run_Id;
            return await this.SendJsonAsync<RunRetrieveParameter, RunRetrieveResponse>(p, CancellationToken.None);
        }
        public async ValueTask<RunRetrieveResponse> RunRetrieveAsync(string thread_Id, string run_Id, CancellationToken cancellationToken)
        {
            var p = new RunRetrieveParameter();
            p.Thread_Id = thread_Id;
            p.Run_Id = run_Id;
            return await this.SendJsonAsync<RunRetrieveParameter, RunRetrieveResponse>(p, cancellationToken);
        }
        public async ValueTask<RunRetrieveResponse> RunRetrieveAsync(RunRetrieveParameter parameter)
        {
            return await this.SendJsonAsync<RunRetrieveParameter, RunRetrieveResponse>(parameter, CancellationToken.None);
        }
        public async ValueTask<RunRetrieveResponse> RunRetrieveAsync(RunRetrieveParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendJsonAsync<RunRetrieveParameter, RunRetrieveResponse>(parameter, cancellationToken);
        }
    }
}
