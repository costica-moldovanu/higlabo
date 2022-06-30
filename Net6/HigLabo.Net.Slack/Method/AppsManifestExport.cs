﻿
namespace HigLabo.Net.Slack
{
    public partial class AppsManifestExportParameter : IRestApiParameter
    {
        string IRestApiParameter.ApiPath { get; } = "apps.manifest.export";
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string App_Id { get; set; }
    }
    public partial class AppsManifestExportResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        /// <summary>
        /// https://api.slack.com/methods/apps.manifest.export
        /// </summary>
        public async Task<AppsManifestExportResponse> AppsManifestExportAsync(string app_Id)
        {
            var p = new AppsManifestExportParameter();
            p.App_Id = app_Id;
            return await this.SendAsync<AppsManifestExportParameter, AppsManifestExportResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://api.slack.com/methods/apps.manifest.export
        /// </summary>
        public async Task<AppsManifestExportResponse> AppsManifestExportAsync(string app_Id, CancellationToken cancellationToken)
        {
            var p = new AppsManifestExportParameter();
            p.App_Id = app_Id;
            return await this.SendAsync<AppsManifestExportParameter, AppsManifestExportResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://api.slack.com/methods/apps.manifest.export
        /// </summary>
        public async Task<AppsManifestExportResponse> AppsManifestExportAsync(AppsManifestExportParameter parameter)
        {
            return await this.SendAsync<AppsManifestExportParameter, AppsManifestExportResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://api.slack.com/methods/apps.manifest.export
        /// </summary>
        public async Task<AppsManifestExportResponse> AppsManifestExportAsync(AppsManifestExportParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<AppsManifestExportParameter, AppsManifestExportResponse>(parameter, cancellationToken);
        }
    }
}
