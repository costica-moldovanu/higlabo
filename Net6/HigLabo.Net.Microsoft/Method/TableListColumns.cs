﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class TableListColumnsParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? Id { get; set; }
            public string? IdOrName { get; set; }
            public string? ItemPath { get; set; }
            public string? ItemsId { get; set; }
            public string? WorksheetsIdOrName { get; set; }
            public string? TablesIdOrName { get; set; }
            public string? RootItemPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Me_Drive_Items_Id_Workbook_Tables_IdOrname_Columns: return $"/me/drive/items/{Id}/workbook/tables/{IdOrName}/columns";
                    case ApiPath.Me_Drive_Root_ItemPath_Workbook_Tables_IdOrname_Columns: return $"/me/drive/root:/{ItemPath}:/workbook/tables/{IdOrName}/columns";
                    case ApiPath.Me_Drive_Items_Id_Workbook_Worksheets_IdOrname_Tables_IdOrname_Columns: return $"/me/drive/items/{ItemsId}/workbook/worksheets/{WorksheetsIdOrName}/tables/{TablesIdOrName}/columns";
                    case ApiPath.Me_Drive_Root_ItemPath_Workbook_Worksheets_IdOrname_Tables_IdOrname_Columns: return $"/me/drive/root:/{RootItemPath}/workbook/worksheets/{WorksheetsIdOrName}/tables/{TablesIdOrName}/columns";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Me_Drive_Items_Id_Workbook_Tables_IdOrname_Columns,
            Me_Drive_Root_ItemPath_Workbook_Tables_IdOrname_Columns,
            Me_Drive_Items_Id_Workbook_Worksheets_IdOrname_Tables_IdOrname_Columns,
            Me_Drive_Root_ItemPath_Workbook_Worksheets_IdOrname_Tables_IdOrname_Columns,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "GET";
        public QueryParameter<Field> Query { get; set; } = new QueryParameter<Field>();
        IQueryParameter IQueryParameterProperty.Query
        {
            get
            {
                return this.Query;
            }
        }
    }
    public partial class TableListColumnsResponse : RestApiResponse
    {
        public WorkbookTableColumn[]? Value { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/table-list-columns?view=graph-rest-1.0
        /// </summary>
        public async Task<TableListColumnsResponse> TableListColumnsAsync()
        {
            var p = new TableListColumnsParameter();
            return await this.SendAsync<TableListColumnsParameter, TableListColumnsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/table-list-columns?view=graph-rest-1.0
        /// </summary>
        public async Task<TableListColumnsResponse> TableListColumnsAsync(CancellationToken cancellationToken)
        {
            var p = new TableListColumnsParameter();
            return await this.SendAsync<TableListColumnsParameter, TableListColumnsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/table-list-columns?view=graph-rest-1.0
        /// </summary>
        public async Task<TableListColumnsResponse> TableListColumnsAsync(TableListColumnsParameter parameter)
        {
            return await this.SendAsync<TableListColumnsParameter, TableListColumnsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/table-list-columns?view=graph-rest-1.0
        /// </summary>
        public async Task<TableListColumnsResponse> TableListColumnsAsync(TableListColumnsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<TableListColumnsParameter, TableListColumnsResponse>(parameter, cancellationToken);
        }
    }
}
