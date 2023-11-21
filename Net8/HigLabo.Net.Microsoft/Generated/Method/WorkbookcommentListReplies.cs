﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workbookcomment-list-replies?view=graph-rest-1.0
    /// </summary>
    public partial class WorkbookcommentListRepliesParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? ItemsId { get; set; }
            public string? CommentsId { get; set; }
            public string? ItemPath { get; set; }
            public string? Id { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Me_Drive_Items_Id_Workbook_Comments_Id_Replies: return $"/me/drive/items/{ItemsId}/workbook/comments/{CommentsId}/replies";
                    case ApiPath.Me_Drive_Root_ItemPath_Workbook_Comments_Id_Replies: return $"/me/drive/root:/{ItemPath}:/workbook/comments/{Id}/replies";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Me_Drive_Items_Id_Workbook_Comments_Id_Replies,
            Me_Drive_Root_ItemPath_Workbook_Comments_Id_Replies,
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
    public partial class WorkbookcommentListRepliesResponse : RestApiResponse
    {
        public WorkbookCommentReply[]? Value { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workbookcomment-list-replies?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/workbookcomment-list-replies?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<WorkbookcommentListRepliesResponse> WorkbookcommentListRepliesAsync()
        {
            var p = new WorkbookcommentListRepliesParameter();
            return await this.SendAsync<WorkbookcommentListRepliesParameter, WorkbookcommentListRepliesResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/workbookcomment-list-replies?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<WorkbookcommentListRepliesResponse> WorkbookcommentListRepliesAsync(CancellationToken cancellationToken)
        {
            var p = new WorkbookcommentListRepliesParameter();
            return await this.SendAsync<WorkbookcommentListRepliesParameter, WorkbookcommentListRepliesResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/workbookcomment-list-replies?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<WorkbookcommentListRepliesResponse> WorkbookcommentListRepliesAsync(WorkbookcommentListRepliesParameter parameter)
        {
            return await this.SendAsync<WorkbookcommentListRepliesParameter, WorkbookcommentListRepliesResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/workbookcomment-list-replies?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<WorkbookcommentListRepliesResponse> WorkbookcommentListRepliesAsync(WorkbookcommentListRepliesParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<WorkbookcommentListRepliesParameter, WorkbookcommentListRepliesResponse>(parameter, cancellationToken);
        }
    }
}
