﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace HigLabo.OpenAI
{
    /// <summary>
    /// Transcribes audio into the input language.
    /// <seealso href="https://api.openai.com/v1/audio/transcriptions">https://api.openai.com/v1/audio/transcriptions</seealso>
    /// </summary>
    public partial class AudioTranscriptionsParameter : RestApiParameter, IRestApiParameter, IFileParameter, IFormDataParameter
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
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
        /// </summary>
        public Stream? File { get; private set; }
        /// <summary>
        /// ID of the model to use. Only whisper-1 is currently available.
        /// </summary>
        public string Model { get; set; } = "";
        /// <summary>
        /// The language of the input audio. Supplying the input language in ISO-639-1 format will improve accuracy and latency.
        /// </summary>
        public string? Language { get; set; }
        /// <summary>
        /// An optional text to guide the model's style or continue a previous audio segment. The prompt should match the audio language.
        /// </summary>
        public string? Prompt { get; set; }
        /// <summary>
        /// The format of the transcript output, in one of these options: json, text, srt, verbose_json, or vtt.
        /// </summary>
        public string? Response_Format { get; set; }
        /// <summary>
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use log probability to automatically increase the temperature until certain thresholds are hit.
        /// </summary>
        public double? Temperature { get; set; }

        string IRestApiParameter.GetApiPath()
        {
            return $"/audio/transcriptions";
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
            	model = this.Model,
            	language = this.Language,
            	prompt = this.Prompt,
            	response_format = this.Response_Format,
            	temperature = this.Temperature,
            };
        }
        Dictionary<string, string> IFormDataParameter.CreateFormDataParameter()
        {
            var d = new Dictionary<string, string>();
            d["model"] = this.Model;
            if (this.Language != null) d["language"] = this.Language;
            if (this.Prompt != null) d["prompt"] = this.Prompt;
            if (this.Response_Format != null) d["response_format"] = this.Response_Format;
            if (this.Temperature != null) d["temperature"] = this.Temperature.Value.ToString();
            return d;
        }
    }
    public partial class AudioTranscriptionsResponse : RestApiResponse
    {
    }
    public partial class OpenAIClient
    {
        public async ValueTask<AudioTranscriptionsResponse> AudioTranscriptionsAsync(string fileName, Stream file, string model)
        {
            var p = new AudioTranscriptionsParameter();
            p.SetFile(fileName, file);
            p.Model = model;
            return await this.SendFormDataAsync<AudioTranscriptionsParameter, AudioTranscriptionsResponse>(p, CancellationToken.None);
        }
        public async ValueTask<AudioTranscriptionsResponse> AudioTranscriptionsAsync(string fileName, Stream file, string model, CancellationToken cancellationToken)
        {
            var p = new AudioTranscriptionsParameter();
            p.SetFile(fileName, file);
            p.Model = model;
            return await this.SendFormDataAsync<AudioTranscriptionsParameter, AudioTranscriptionsResponse>(p, cancellationToken);
        }
        public async ValueTask<AudioTranscriptionsResponse> AudioTranscriptionsAsync(AudioTranscriptionsParameter parameter)
        {
            return await this.SendFormDataAsync<AudioTranscriptionsParameter, AudioTranscriptionsResponse>(parameter, CancellationToken.None);
        }
        public async ValueTask<AudioTranscriptionsResponse> AudioTranscriptionsAsync(AudioTranscriptionsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendFormDataAsync<AudioTranscriptionsParameter, AudioTranscriptionsResponse>(parameter, cancellationToken);
        }
    }
}
