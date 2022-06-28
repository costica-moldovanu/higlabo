﻿
namespace HigLabo.Net.Slack
{
    public class FilesRemoteAddParameter : IRestApiParameter
    {
        public string ApiPath { get; private set; } = "files.remote.add";
        public string HttpMethod { get; private set; } = "GET";
        public string External_Id { get; set; } = "";
        public string External_Url { get; set; } = "";
        public string Title { get; set; } = "";
        public string Filetype { get; set; } = "";
        public string Indexable_File_Contents { get; set; } = "";
        public string Preview_Image { get; set; } = "";
    }
    public partial class FilesRemoteAddResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        public async Task<FilesRemoteAddResponse> FilesRemoteAddAsync(string external_Id, string external_Url, string title)
        {
            var p = new FilesRemoteAddParameter();
            p.External_Id = external_Id;
            p.External_Url = external_Url;
            p.Title = title;
            return await this.SendAsync<FilesRemoteAddParameter, FilesRemoteAddResponse>(p, CancellationToken.None);
        }
        public async Task<FilesRemoteAddResponse> FilesRemoteAddAsync(string external_Id, string external_Url, string title, CancellationToken cancellationToken)
        {
            var p = new FilesRemoteAddParameter();
            p.External_Id = external_Id;
            p.External_Url = external_Url;
            p.Title = title;
            return await this.SendAsync<FilesRemoteAddParameter, FilesRemoteAddResponse>(p, cancellationToken);
        }
        public async Task<FilesRemoteAddResponse> FilesRemoteAddAsync(FilesRemoteAddParameter parameter)
        {
            return await this.SendAsync<FilesRemoteAddParameter, FilesRemoteAddResponse>(parameter, CancellationToken.None);
        }
        public async Task<FilesRemoteAddResponse> FilesRemoteAddAsync(FilesRemoteAddParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<FilesRemoteAddParameter, FilesRemoteAddResponse>(parameter, cancellationToken);
        }
    }
}
