﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace HigLabo.OpenAI
{
    /// <summary>
    /// Upload a file that can be used across various endpoints. The size of all the files uploaded by one organization can be up to 100 GB.The size of individual files can be a maximum of 512 MB. See the Assistants Tools guide to learn more about the types of files supported. The Fine-tuning API only supports .jsonl files.Please contact us if you need to increase these storage limits.
    /// <seealso href="https://api.openai.com/v1/files">https://api.openai.com/v1/files</seealso>
    /// </summary>
    public partial class FileUploadParameter : RestApiParameter, IRestApiParameter, IFileParameter, IFormDataParameter
    {
        string IRestApiParameter.HttpMethod { get; } = "POST";
        string IFileParameter.ParameterName
        {
            get
            {
                return "file";
            }
        }
        string IFileParameter.FileName { get; set; } = "";
        /// <summary>
        /// The File object (not file name) to be uploaded.
        /// </summary>
        public Stream? File { get; private set; }
        /// <summary>
        /// The intended purpose of the uploaded file.Use "fine-tune" for Fine-tuning and "assistants" for Assistants and Messages. This allows us to validate the format of the uploaded file is correct for fine-tuning.
        /// </summary>
        public string Purpose { get; set; } = "";

        string IRestApiParameter.GetApiPath()
        {
            return $"/files";
        }
        Stream IFileParameter.GetFileStream()
        {
            if (this.File == null) throw new InvalidOperationException("File property must be set.");
            return this.File;
        }
        public void SetFile(string fileName, Stream stream)
        {
            ((IFileParameter)this).FileName = fileName;
            this.File = stream;
        }
        public override object GetRequestBody()
        {
            return new {
            	file = this.File,
            	purpose = this.Purpose,
            };
        }
        Dictionary<string, string> IFormDataParameter.CreateFormDataParameter()
        {
            var d = new Dictionary<string, string>();
            d["purpose"] = this.Purpose;
            return d;
        }
    }
    public partial class FileUploadResponse : FileObjectResponse
    {
    }
    public partial class OpenAIClient
    {
        public async ValueTask<FileUploadResponse> FileUploadAsync(string fileName, Stream file, string purpose)
        {
            var p = new FileUploadParameter();
            p.SetFile(fileName, file);
            p.Purpose = purpose;
            return await this.SendFormDataAsync<FileUploadParameter, FileUploadResponse>(p, CancellationToken.None);
        }
        public async ValueTask<FileUploadResponse> FileUploadAsync(string fileName, Stream file, string purpose, CancellationToken cancellationToken)
        {
            var p = new FileUploadParameter();
            p.SetFile(fileName, file);
            p.Purpose = purpose;
            return await this.SendFormDataAsync<FileUploadParameter, FileUploadResponse>(p, cancellationToken);
        }
        public async ValueTask<FileUploadResponse> FileUploadAsync(FileUploadParameter parameter)
        {
            return await this.SendFormDataAsync<FileUploadParameter, FileUploadResponse>(parameter, CancellationToken.None);
        }
        public async ValueTask<FileUploadResponse> FileUploadAsync(FileUploadParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendFormDataAsync<FileUploadParameter, FileUploadResponse>(parameter, cancellationToken);
        }
    }
}
