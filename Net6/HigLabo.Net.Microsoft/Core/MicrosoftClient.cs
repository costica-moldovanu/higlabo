﻿using HigLabo.Core;
using HigLabo.Net.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.Net.Microsoft
{
    public partial class MicrosoftClient : OAuthClient
    {
        public static String ApiUrl = "https://graph.microsoft.com/v1.0/";

        public MicrosoftClient(string accessToken)
        {
            this.AccessToken = accessToken;
        }
        public MicrosoftClient(OAuthSetting setting)
        {
            this.OAuthSetting = setting;
        }
        public MicrosoftClient(string accessToken, string refreshToken, OAuthSetting setting)
        {
            this.AccessToken = accessToken;
            this.RefreshToken = refreshToken;
            this.OAuthSetting = setting;
        }

        private HttpRequestMessage CreateHttpRequestMessage(String url, HttpMethod httpMethod)
        {
            var mg = new HttpRequestMessage(httpMethod, url);
            mg.Headers.Authorization = new AuthenticationHeaderValue("Bearer", this.AccessToken);
            return mg;
        }
        public override async Task<TResponse> SendAsync<TParameter, TResponse>(TParameter parameter, CancellationToken cancellationToken)
        {
            Func<Task<TResponse>> f = null;
            if (string.Equals(parameter.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
            {
                var queryString = "";
                if (parameter is IQueryParameterProperty q)
                {
                    queryString = q.Query.GetQueryString();
                }
                f = () => this.SendAsync<TResponse>(this.CreateHttpRequestMessage(ApiUrl + parameter.ApiPath + "?" + queryString, new HttpMethod(parameter.HttpMethod)), cancellationToken);
            }
            else
            {
                f = () => this.SendJsonAsync<TResponse>(this.CreateHttpRequestMessage(ApiUrl + parameter.ApiPath, new HttpMethod(parameter.HttpMethod)), parameter, cancellationToken);
            }
            return await this.ProcessRequest(f);
        }
        public async Task<Stream> DownloadStreamAsync(IRestApiParameter parameter, CancellationToken cancellationToken)
        {
            var p = parameter;
            var queryString = "";
            if (parameter is IQueryParameterProperty q)
            {
                queryString = q.Query.GetQueryString();
            }
            var f = () => this.DownloadStreamAsync(this.CreateHttpRequestMessage(ApiUrl + p.ApiPath + "?" + queryString, new HttpMethod(p.HttpMethod)), cancellationToken);
            return await this.ProcessRequest(f);
        }

        protected override async Task ProcessAccessTokenAsync()
        {
            var result = await this.UpdateAccessTokenAsync();
            if (((IRestApiResponse)result).StatusCode == HttpStatusCode.OK)
            {
                this.AccessToken = result.Access_Token;
                this.RefreshToken = result.Refresh_Token;
            }
        }
        public async Task<RequestCodeResponse> RequestCodeAsync(string code)
        {
            if (this.OAuthSetting == null)
            { throw new InvalidOperationException("AuthorizationUrlBuilder property is null. Please set SlackClient.OAuthSetting property."); }

            var cl = this;
            var b = this.OAuthSetting as OAuthSetting;
            var req = new HttpRequestMessage(HttpMethod.Post, "https://login.microsoftonline.com/common/oauth2/v2.0/token");

            var d = new Dictionary<string, string>();
            d["code"] = code;
            d["grant_type"] = "authorization_code";
            d["access_type"] = "offline";
            d["client_id"] = b.ClientId;
            d["client_secret"] = b.ClientSecret;
            d["redirect_uri"] = b.RedirectUrl;
            req.Content = new FormUrlEncodedContent(d);

            var res = await cl.SendAsync(req);
            var bodyText = await res.Content.ReadAsStringAsync();
            return this.ParseObject<RequestCodeResponse>(d, req, res, bodyText);
        }
        public async Task<RequestCodeResponse> UpdateAccessTokenAsync()
        {
            if (this.OAuthSetting == null)
            { throw new InvalidOperationException("AuthorizationUrlBuilder property is null. Please set SlackClient.OAuthSetting property."); }

            var cl = this;
            var b = this.OAuthSetting as OAuthSetting;
            var req = new HttpRequestMessage(HttpMethod.Post, "https://login.microsoftonline.com/common/oauth2/v2.0/token");

            var d = new Dictionary<string, string>();
            d["client_id"] = b.ClientId;
            d["client_secret"] = b.ClientSecret;
            d["grant_type"] = "refresh_token";
            d["refresh_token"] = this.RefreshToken;
            d["scope"] = String.Join(" ", b.ScopeList.Select(el => el.GetScopeName()));
            d["redirect_uri"] = b.RedirectUrl;
            req.Content = new FormUrlEncodedContent(d);

            var res = await cl.SendAsync(req);
            var bodyText = await res.Content.ReadAsStringAsync();
            var o = this.ParseObject<RequestCodeResponse>(d, req, res, bodyText);
            if (o is IRestApiResponse iRes && iRes.StatusCode == HttpStatusCode.OK)
            {
                this.OnAccessTokenUpdated(new AccessTokenUpdatedEventArgs(o));
            }
            return o;
        }

    }
}
