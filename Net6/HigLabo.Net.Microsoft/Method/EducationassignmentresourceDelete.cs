﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class EducationAssignmentResourceDeleteParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? ClassId { get; set; }
            public string? AssignmentId { get; set; }
            public string? ResourceId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Education_Classes_ClassId_Assignments_AssignmentId_Resources_ResourceId: return $"/education/classes/{ClassId}/assignments/{AssignmentId}/resources/{ResourceId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Education_Classes_ClassId_Assignments_AssignmentId_Resources_ResourceId,
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
    public partial class EducationAssignmentResourceDeleteResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/educationassignmentresource-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<EducationAssignmentResourceDeleteResponse> EducationAssignmentResourceDeleteAsync()
        {
            var p = new EducationAssignmentResourceDeleteParameter();
            return await this.SendAsync<EducationAssignmentResourceDeleteParameter, EducationAssignmentResourceDeleteResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/educationassignmentresource-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<EducationAssignmentResourceDeleteResponse> EducationAssignmentResourceDeleteAsync(CancellationToken cancellationToken)
        {
            var p = new EducationAssignmentResourceDeleteParameter();
            return await this.SendAsync<EducationAssignmentResourceDeleteParameter, EducationAssignmentResourceDeleteResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/educationassignmentresource-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<EducationAssignmentResourceDeleteResponse> EducationAssignmentResourceDeleteAsync(EducationAssignmentResourceDeleteParameter parameter)
        {
            return await this.SendAsync<EducationAssignmentResourceDeleteParameter, EducationAssignmentResourceDeleteResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/educationassignmentresource-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<EducationAssignmentResourceDeleteResponse> EducationAssignmentResourceDeleteAsync(EducationAssignmentResourceDeleteParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<EducationAssignmentResourceDeleteParameter, EducationAssignmentResourceDeleteResponse>(parameter, cancellationToken);
        }
    }
}
