﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/employeeexperience-post-learningproviders?view=graph-rest-1.0
    /// </summary>
    public partial class EmployeeexperiencePostLearningprovidersParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.EmployeeExperience_LearningProviders: return $"/employeeExperience/learningProviders";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            EmployeeExperience_LearningProviders,
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
        public string? DisplayName { get; set; }
        public string? LoginWebUrl { get; set; }
        public string? LongLogoWebUrlForDarkTheme { get; set; }
        public string? LongLogoWebUrlForLightTheme { get; set; }
        public string? SquareLogoWebUrlForDarkTheme { get; set; }
        public string? SquareLogoWebUrlForLightTheme { get; set; }
        public string? Id { get; set; }
        public LearningContent[]? LearningContents { get; set; }
    }
    public partial class EmployeeexperiencePostLearningprovidersResponse : RestApiResponse
    {
        public string? DisplayName { get; set; }
        public string? Id { get; set; }
        public string? LoginWebUrl { get; set; }
        public string? LongLogoWebUrlForDarkTheme { get; set; }
        public string? LongLogoWebUrlForLightTheme { get; set; }
        public string? SquareLogoWebUrlForDarkTheme { get; set; }
        public string? SquareLogoWebUrlForLightTheme { get; set; }
        public LearningContent[]? LearningContents { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/employeeexperience-post-learningproviders?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/employeeexperience-post-learningproviders?view=graph-rest-1.0
        /// </summary>
        public async Task<EmployeeexperiencePostLearningprovidersResponse> EmployeeexperiencePostLearningprovidersAsync()
        {
            var p = new EmployeeexperiencePostLearningprovidersParameter();
            return await this.SendAsync<EmployeeexperiencePostLearningprovidersParameter, EmployeeexperiencePostLearningprovidersResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/employeeexperience-post-learningproviders?view=graph-rest-1.0
        /// </summary>
        public async Task<EmployeeexperiencePostLearningprovidersResponse> EmployeeexperiencePostLearningprovidersAsync(CancellationToken cancellationToken)
        {
            var p = new EmployeeexperiencePostLearningprovidersParameter();
            return await this.SendAsync<EmployeeexperiencePostLearningprovidersParameter, EmployeeexperiencePostLearningprovidersResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/employeeexperience-post-learningproviders?view=graph-rest-1.0
        /// </summary>
        public async Task<EmployeeexperiencePostLearningprovidersResponse> EmployeeexperiencePostLearningprovidersAsync(EmployeeexperiencePostLearningprovidersParameter parameter)
        {
            return await this.SendAsync<EmployeeexperiencePostLearningprovidersParameter, EmployeeexperiencePostLearningprovidersResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/employeeexperience-post-learningproviders?view=graph-rest-1.0
        /// </summary>
        public async Task<EmployeeexperiencePostLearningprovidersResponse> EmployeeexperiencePostLearningprovidersAsync(EmployeeexperiencePostLearningprovidersParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<EmployeeexperiencePostLearningprovidersParameter, EmployeeexperiencePostLearningprovidersResponse>(parameter, cancellationToken);
        }
    }
}
