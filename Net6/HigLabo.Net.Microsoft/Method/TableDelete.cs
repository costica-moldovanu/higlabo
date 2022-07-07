﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class TableDeleteParameter : IRestApiParameter
    {
        public enum ApiPath
        {
            Me_Drive_Items_Id_Workbook_Tables_IdOrname,
            Me_Drive_Root_ItemPath_Workbook_Tables_IdOrname,
            Me_Drive_Items_Id_Workbook_Worksheets_IdOrname_Tables_IdOrname,
            Me_Drive_Root_ItemPath_Workbook_Worksheets_IdOrname_Tables_IdOrname,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.Me_Drive_Items_Id_Workbook_Tables_IdOrname: return $"/me/drive/items/{Id}/workbook/tables/{IdOrName}";
                    case ApiPath.Me_Drive_Root_ItemPath_Workbook_Tables_IdOrname: return $"/me/drive/root:/{ItemPath}:/workbook/tables/{IdOrName}";
                    case ApiPath.Me_Drive_Items_Id_Workbook_Worksheets_IdOrname_Tables_IdOrname: return $"/me/drive/items/{ItemsId}/workbook/worksheets/{WorksheetsIdOrName}/tables/{TablesIdOrName}";
                    case ApiPath.Me_Drive_Root_ItemPath_Workbook_Worksheets_IdOrname_Tables_IdOrname: return $"/me/drive/root:/{RootItemPath}/workbook/worksheets/{WorksheetsIdOrName}/tables/{TablesIdOrName}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "DELETE";
        public string Id { get; set; }
        public string IdOrName { get; set; }
        public string ItemPath { get; set; }
        public string ItemsId { get; set; }
        public string WorksheetsIdOrName { get; set; }
        public string TablesIdOrName { get; set; }
        public string RootItemPath { get; set; }
    }
    public partial class TableDeleteResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/table-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<TableDeleteResponse> TableDeleteAsync()
        {
            var p = new TableDeleteParameter();
            return await this.SendAsync<TableDeleteParameter, TableDeleteResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/table-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<TableDeleteResponse> TableDeleteAsync(CancellationToken cancellationToken)
        {
            var p = new TableDeleteParameter();
            return await this.SendAsync<TableDeleteParameter, TableDeleteResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/table-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<TableDeleteResponse> TableDeleteAsync(TableDeleteParameter parameter)
        {
            return await this.SendAsync<TableDeleteParameter, TableDeleteResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/table-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<TableDeleteResponse> TableDeleteAsync(TableDeleteParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<TableDeleteParameter, TableDeleteResponse>(parameter, cancellationToken);
        }
    }
}
