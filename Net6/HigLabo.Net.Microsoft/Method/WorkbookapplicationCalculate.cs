﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class WorkbookapplicationCalculateParameter : IRestApiParameter
    {
        public enum WorkbookapplicationCalculateParameterstring
        {
            Recalculate,
            Full,
            FullRebuild,
        }
        public enum ApiPath
        {
            Me_Drive_Items_Id_Workbook_Application_Calculate,
            Me_Drive_Root_ItemPath_Workbook_Application_Calculate,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Me_Drive_Items_Id_Workbook_Application_Calculate: return $"/me/drive/items/{Id}/workbook/application/calculate";
                    case ApiPath.Me_Drive_Root_ItemPath_Workbook_Application_Calculate: return $"/me/drive/root:/{ItemPath}:/workbook/application/calculate";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public WorkbookapplicationCalculateParameterstring CalculationType { get; set; }
        public string Id { get; set; }
        public string ItemPath { get; set; }
    }
    public partial class WorkbookapplicationCalculateResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/workbookapplication-calculate?view=graph-rest-1.0
        /// </summary>
        public async Task<WorkbookapplicationCalculateResponse> WorkbookapplicationCalculateAsync()
        {
            var p = new WorkbookapplicationCalculateParameter();
            return await this.SendAsync<WorkbookapplicationCalculateParameter, WorkbookapplicationCalculateResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/workbookapplication-calculate?view=graph-rest-1.0
        /// </summary>
        public async Task<WorkbookapplicationCalculateResponse> WorkbookapplicationCalculateAsync(CancellationToken cancellationToken)
        {
            var p = new WorkbookapplicationCalculateParameter();
            return await this.SendAsync<WorkbookapplicationCalculateParameter, WorkbookapplicationCalculateResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/workbookapplication-calculate?view=graph-rest-1.0
        /// </summary>
        public async Task<WorkbookapplicationCalculateResponse> WorkbookapplicationCalculateAsync(WorkbookapplicationCalculateParameter parameter)
        {
            return await this.SendAsync<WorkbookapplicationCalculateParameter, WorkbookapplicationCalculateResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/workbookapplication-calculate?view=graph-rest-1.0
        /// </summary>
        public async Task<WorkbookapplicationCalculateResponse> WorkbookapplicationCalculateAsync(WorkbookapplicationCalculateParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<WorkbookapplicationCalculateParameter, WorkbookapplicationCalculateResponse>(parameter, cancellationToken);
        }
    }
}
