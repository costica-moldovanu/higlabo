﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class FeaturerolloutPolicyDeleteAppliestoParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? PolicyId { get; set; }
            public string? DirectoryObjectId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Policies_FeatureRolloutPolicies_PolicyId_AppliesTo_DirectoryObjectId_ref: return $"/policies/featureRolloutPolicies/{PolicyId}/appliesTo/{DirectoryObjectId}/$ref";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Policies_FeatureRolloutPolicies_PolicyId_AppliesTo_DirectoryObjectId_ref,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "DELETE";
    }
    public partial class FeaturerolloutPolicyDeleteAppliestoResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/featurerolloutpolicy-delete-appliesto?view=graph-rest-1.0
        /// </summary>
        public async Task<FeaturerolloutPolicyDeleteAppliestoResponse> FeaturerolloutPolicyDeleteAppliestoAsync()
        {
            var p = new FeaturerolloutPolicyDeleteAppliestoParameter();
            return await this.SendAsync<FeaturerolloutPolicyDeleteAppliestoParameter, FeaturerolloutPolicyDeleteAppliestoResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/featurerolloutpolicy-delete-appliesto?view=graph-rest-1.0
        /// </summary>
        public async Task<FeaturerolloutPolicyDeleteAppliestoResponse> FeaturerolloutPolicyDeleteAppliestoAsync(CancellationToken cancellationToken)
        {
            var p = new FeaturerolloutPolicyDeleteAppliestoParameter();
            return await this.SendAsync<FeaturerolloutPolicyDeleteAppliestoParameter, FeaturerolloutPolicyDeleteAppliestoResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/featurerolloutpolicy-delete-appliesto?view=graph-rest-1.0
        /// </summary>
        public async Task<FeaturerolloutPolicyDeleteAppliestoResponse> FeaturerolloutPolicyDeleteAppliestoAsync(FeaturerolloutPolicyDeleteAppliestoParameter parameter)
        {
            return await this.SendAsync<FeaturerolloutPolicyDeleteAppliestoParameter, FeaturerolloutPolicyDeleteAppliestoResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/featurerolloutpolicy-delete-appliesto?view=graph-rest-1.0
        /// </summary>
        public async Task<FeaturerolloutPolicyDeleteAppliestoResponse> FeaturerolloutPolicyDeleteAppliestoAsync(FeaturerolloutPolicyDeleteAppliestoParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<FeaturerolloutPolicyDeleteAppliestoParameter, FeaturerolloutPolicyDeleteAppliestoResponse>(parameter, cancellationToken);
        }
    }
}
