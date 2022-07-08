﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class OffershiftrequestApproveParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string TeamId { get; set; }
            public string OfferShiftRequestId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Teams_TeamId_Schedule_OfferShiftRequests_OfferShiftRequestId_Approve: return $"/teams/{TeamId}/schedule/offerShiftRequests/{OfferShiftRequestId}/approve";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Teams_TeamId_Schedule_OfferShiftRequests_OfferShiftRequestId_Approve,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string? Message { get; set; }
    }
    public partial class OffershiftrequestApproveResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/offershiftrequest-approve?view=graph-rest-1.0
        /// </summary>
        public async Task<OffershiftrequestApproveResponse> OffershiftrequestApproveAsync()
        {
            var p = new OffershiftrequestApproveParameter();
            return await this.SendAsync<OffershiftrequestApproveParameter, OffershiftrequestApproveResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/offershiftrequest-approve?view=graph-rest-1.0
        /// </summary>
        public async Task<OffershiftrequestApproveResponse> OffershiftrequestApproveAsync(CancellationToken cancellationToken)
        {
            var p = new OffershiftrequestApproveParameter();
            return await this.SendAsync<OffershiftrequestApproveParameter, OffershiftrequestApproveResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/offershiftrequest-approve?view=graph-rest-1.0
        /// </summary>
        public async Task<OffershiftrequestApproveResponse> OffershiftrequestApproveAsync(OffershiftrequestApproveParameter parameter)
        {
            return await this.SendAsync<OffershiftrequestApproveParameter, OffershiftrequestApproveResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/offershiftrequest-approve?view=graph-rest-1.0
        /// </summary>
        public async Task<OffershiftrequestApproveResponse> OffershiftrequestApproveAsync(OffershiftrequestApproveParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<OffershiftrequestApproveParameter, OffershiftrequestApproveResponse>(parameter, cancellationToken);
        }
    }
}
