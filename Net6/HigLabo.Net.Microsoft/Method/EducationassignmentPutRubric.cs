﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class EducationAssignmentPutRubricParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Education_Classes_Acdefc6b2dc64e71B1e96d9810ab1793_Assignments_Cf6005fc9e1344a2A6acA53322006454_Rubric_ref: return $"/education/classes/acdefc6b-2dc6-4e71-b1e9-6d9810ab1793/assignments/cf6005fc-9e13-44a2-a6ac-a53322006454/rubric/$ref";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Education_Classes_Acdefc6b2dc64e71B1e96d9810ab1793_Assignments_Cf6005fc9e1344a2A6acA53322006454_Rubric_ref,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "PUT";
    }
    public partial class EducationAssignmentPutRubricResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/educationassignment-put-rubric?view=graph-rest-1.0
        /// </summary>
        public async Task<EducationAssignmentPutRubricResponse> EducationAssignmentPutRubricAsync()
        {
            var p = new EducationAssignmentPutRubricParameter();
            return await this.SendAsync<EducationAssignmentPutRubricParameter, EducationAssignmentPutRubricResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/educationassignment-put-rubric?view=graph-rest-1.0
        /// </summary>
        public async Task<EducationAssignmentPutRubricResponse> EducationAssignmentPutRubricAsync(CancellationToken cancellationToken)
        {
            var p = new EducationAssignmentPutRubricParameter();
            return await this.SendAsync<EducationAssignmentPutRubricParameter, EducationAssignmentPutRubricResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/educationassignment-put-rubric?view=graph-rest-1.0
        /// </summary>
        public async Task<EducationAssignmentPutRubricResponse> EducationAssignmentPutRubricAsync(EducationAssignmentPutRubricParameter parameter)
        {
            return await this.SendAsync<EducationAssignmentPutRubricParameter, EducationAssignmentPutRubricResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/educationassignment-put-rubric?view=graph-rest-1.0
        /// </summary>
        public async Task<EducationAssignmentPutRubricResponse> EducationAssignmentPutRubricAsync(EducationAssignmentPutRubricParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<EducationAssignmentPutRubricParameter, EducationAssignmentPutRubricResponse>(parameter, cancellationToken);
        }
    }
}
