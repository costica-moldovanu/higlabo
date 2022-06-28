﻿
namespace HigLabo.Net.Slack
{
    public class FilesRemoteShareParameter : IRestApiParameter
    {
        public string ApiPath { get; private set; } = "files.remote.share";
        public string HttpMethod { get; private set; } = "GET";
        public string Channels { get; set; } = "";
        public string External_Id { get; set; } = "";
        public string File { get; set; } = "";
    }
    public partial class FilesRemoteShareResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        public async Task<FilesRemoteShareResponse> FilesRemoteShareAsync(string channels)
        {
            var p = new FilesRemoteShareParameter();
            p.Channels = channels;
            return await this.SendAsync<FilesRemoteShareParameter, FilesRemoteShareResponse>(p, CancellationToken.None);
        }
        public async Task<FilesRemoteShareResponse> FilesRemoteShareAsync(string channels, CancellationToken cancellationToken)
        {
            var p = new FilesRemoteShareParameter();
            p.Channels = channels;
            return await this.SendAsync<FilesRemoteShareParameter, FilesRemoteShareResponse>(p, cancellationToken);
        }
        public async Task<FilesRemoteShareResponse> FilesRemoteShareAsync(FilesRemoteShareParameter parameter)
        {
            return await this.SendAsync<FilesRemoteShareParameter, FilesRemoteShareResponse>(parameter, CancellationToken.None);
        }
        public async Task<FilesRemoteShareResponse> FilesRemoteShareAsync(FilesRemoteShareParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<FilesRemoteShareParameter, FilesRemoteShareResponse>(parameter, cancellationToken);
        }
    }
}
