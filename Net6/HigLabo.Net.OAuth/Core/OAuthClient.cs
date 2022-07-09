﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HigLabo.Core;

namespace HigLabo.Net.OAuth
{
    public abstract class OAuthClient : HttpClient
    {
        public IJsonConverter? JsonConverter { get; init; }

        public event EventHandler<AccessTokenUpdatedEventArgs>? AccessTokenUpdated;

        public string AccessToken { get; set; } = "";
        public string RefreshToken { get; set; } = "";
        public OAuthSetting? OAuthSetting { get; set; }
        public Boolean IsThrowException { get; set; } = true;

        protected OAuthClient(IJsonConverter jsonConverter)
        {
            this.JsonConverter = jsonConverter;
        }

        protected void OnAccessTokenUpdated(AccessTokenUpdatedEventArgs e)
        {
            this.AccessTokenUpdated?.Invoke(this, e);
        }

        protected string SerializeObject(object obj)
        {
            return this.JsonConverter.SerializeObject(obj);
        }
        protected T DeserializeObject<T>(String json)
        {
            return this.JsonConverter.DeserializeObject<T>(json);
        }

        protected T ParseObject<T>(HttpRequestMessage request, HttpResponseMessage response, string bodyText)
            where T : RestApiResponse
        {
            return this.ParseObject<T>(null, "", request, response, bodyText);
        }
        protected T ParseObject<T>(Dictionary<string, string> parameter, HttpRequestMessage request, HttpResponseMessage response, string bodyText)
            where T : RestApiResponse
        {
            var d = parameter;
            var q = new QueryStringConverter();
            return this.ParseObject<T>(parameter, q.Write(d), request, response, bodyText);
        }
        protected T ParseObject<T>(object parameter, string requestBodyText, HttpRequestMessage request, HttpResponseMessage response, string bodyText)
            where T : RestApiResponse
        {
            var req = request;
            var o = this.DeserializeObject<T>(bodyText);
            o.SetProperty(parameter, requestBodyText, req, response, bodyText);
            if (this.IsThrowException == true && o.IsThrowException())
            {
                throw new RestApiException(o);
            }
            return o;
        }

        protected async Task<TResponse> ProcessRequest<TResponse>(Func<Task<TResponse>> func)
        {
            var isFirst = true;

            while (true)
            {
                try
                {
                    return await func();
                }
                catch
                {
                    if (isFirst == false) { throw; }
                    isFirst = false;
                }
                try
                {
                    await this.ProcessAccessTokenAsync();
                }
                catch { }
            }
        }
        protected abstract Task ProcessAccessTokenAsync();

        protected async Task<TResponse> SendAsync<TResponse>(HttpRequestMessage request, CancellationToken cancellationToken)
            where TResponse : RestApiResponse
        {
            var req = request;
            var res = await this.SendAsync(req);
            var bodyText = await res.Content.ReadAsStringAsync(cancellationToken);
            return this.ParseObject<TResponse>(req, res, bodyText);
        }
        protected async Task<TResponse> SendFormAsync<TResponse>(HttpRequestMessage request, Dictionary<String, String> parameter, CancellationToken cancellationToken)
            where TResponse : RestApiResponse
        {
            var req = request;
            var d = new Dictionary<String, String>();
            foreach (var key in parameter.Keys)
            {
                d[key.ToLower()] = parameter[key];
            }
            req.Content = new FormUrlEncodedContent(d);
            var res = await this.SendAsync(req);
            var bodyText = await res.Content.ReadAsStringAsync(cancellationToken);
            return this.ParseObject<TResponse>(d, req, res, bodyText);
        }
        protected async Task<TResponse> SendJsonAsync<TResponse>(HttpRequestMessage request, object parameter, CancellationToken cancellationToken)
            where TResponse : RestApiResponse
        {
            var req = request;
            var json = this.SerializeObject(parameter);
            req.Content = new StringContent(json, Encoding.UTF8, "application/json");
            var res = await this.SendAsync(req);
            var bodyText = await res.Content.ReadAsStringAsync(cancellationToken);
            return this.ParseObject<TResponse>(parameter, json, req, res, bodyText);
        }
        protected async Task<Stream> DownloadStreamAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var req = request;
            var res = await this.SendAsync(req, cancellationToken);
            return await res.Content.ReadAsStreamAsync(cancellationToken);
        }

        public async Task<TResponse> SendAsync<TParameter, TResponse>(TParameter parameter)
            where TParameter : IRestApiParameter
            where TResponse : RestApiResponse
        {
            return await this.SendAsync<TParameter, TResponse>(parameter, CancellationToken.None);
        }
        public abstract Task<TResponse> SendAsync<TParameter, TResponse>(TParameter parameter, CancellationToken cancellationToken)
            where TParameter : IRestApiParameter
            where TResponse : RestApiResponse;
        public async Task<List<TResponse>> SendBatchAsync<TParameter, TResponse>(TParameter parameter, PagingContext<TResponse> context)
            where TParameter : IRestApiParameter, IRestApiPagingParameter
            where TResponse : RestApiResponse
        {
            return await this.SendBatchAsync(parameter, context, CancellationToken.None);
        }
        public async Task<List<TResponse>> SendBatchAsync<TParameter, TResponse>(TParameter parameter, PagingContext<TResponse> context, CancellationToken cancellationToken)
            where TParameter : IRestApiParameter, IRestApiPagingParameter
            where TResponse : RestApiResponse
        {
            var p = parameter;
            var l = new List<TResponse>();
            while (true)
            {
                var res = await this.SendAsync<TParameter, TResponse>(p, cancellationToken);
                l.Add(res);

                context.InvokeResponseReceived(new ResponseReceivedEventArgs<TResponse>(this, l));
                if (context.Break) { break; }
                if (res.GetNextPageToken().IsNullOrEmpty()) { break; }
                p.NextPageToken = res.GetNextPageToken();
            }
            return l;
        }
    }
}
