﻿using System.Runtime.CompilerServices;

namespace HigLabo.OpenAI
{
    /// <summary>
    /// Returns a list of message files.
    /// <seealso href="https://api.openai.com/v1/threads/{thread_id}/messages/{message_id}/files">https://api.openai.com/v1/threads/{thread_id}/messages/{message_id}/files</seealso>
    /// </summary>
    public partial class MessageFilesParameter : IRestApiParameter
    {
        string IRestApiParameter.HttpMethod { get; } = "GET";
        /// <summary>
        /// The ID of the thread that the message and files belong to.
        /// </summary>
        public string Thread_Id { get; set; } = "";
        /// <summary>
        /// The ID of the message that the files belongs to.
        /// </summary>
        public string Message_Id { get; set; } = "";

        string IRestApiParameter.GetApiPath()
        {
            return $"/threads/{Thread_Id}/messages/{Message_Id}/files";
        }
    }
    public partial class MessageFilesResponse : RestApiDataResponse<List<MessageFileObject>>
    {
    }
    public partial class OpenAIClient
    {
        public async ValueTask<MessageFilesResponse> MessageFilesAsync(string thread_Id, string message_Id)
        {
            var p = new MessageFilesParameter();
            p.Thread_Id = thread_Id;
            p.Message_Id = message_Id;
            return await this.SendJsonAsync<MessageFilesParameter, MessageFilesResponse>(p, CancellationToken.None);
        }
        public async ValueTask<MessageFilesResponse> MessageFilesAsync(string thread_Id, string message_Id, CancellationToken cancellationToken)
        {
            var p = new MessageFilesParameter();
            p.Thread_Id = thread_Id;
            p.Message_Id = message_Id;
            return await this.SendJsonAsync<MessageFilesParameter, MessageFilesResponse>(p, cancellationToken);
        }
        public async ValueTask<MessageFilesResponse> MessageFilesAsync(MessageFilesParameter parameter)
        {
            return await this.SendJsonAsync<MessageFilesParameter, MessageFilesResponse>(parameter, CancellationToken.None);
        }
        public async ValueTask<MessageFilesResponse> MessageFilesAsync(MessageFilesParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendJsonAsync<MessageFilesParameter, MessageFilesResponse>(parameter, cancellationToken);
        }
    }
}
