﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.OpenAI
{
    public class OpenAIServerError
    {
        public string Code { get; set; } = "";
        public string Message { get; set; } = "";
        public string Param { get; set; } = "";
        public string Type { get; set; } = "";
    }
    public class OpenAIServerErrorResponse
    {
        public OpenAIServerError Error { get; set; } = new OpenAIServerError();
    }
    public class OpenAIServerException : Exception
    {
        public object Parameter { get; set; }
        public HttpRequestMessage Request { get; set; }
        public string RequestBodyText { get; set; } 
        public HttpResponseMessage Response { get; set; }
        public string ResponseBodyText { get; set; } = "";
        public OpenAIServerError Error { get; set; }

        public OpenAIServerException(object parameter, HttpRequestMessage request, string requestBodyText
            , HttpResponseMessage response, string responseBodyText, OpenAIServerError error)
            : base(error.Message)
        {
            this.Parameter = parameter;
            this.Request = request;
            this.RequestBodyText = requestBodyText;
            this.Response = response;
            this.ResponseBodyText = responseBodyText;
            this.Error = error;
        }
    }
}
