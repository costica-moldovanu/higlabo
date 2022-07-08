﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class NotebookListSectionsParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string Id { get; set; }
            public string IdOrUserPrincipalName { get; set; }
            public string GroupsId { get; set; }
            public string NotebooksId { get; set; }
            public string SitesId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Me_Onenote_Notebooks_Id_Sections: return $"/me/onenote/notebooks/{Id}/sections";
                    case ApiPath.Users_IdOrUserPrincipalName_Onenote_Notebooks_Id_Sections: return $"/users/{IdOrUserPrincipalName}/onenote/notebooks/{Id}/sections";
                    case ApiPath.Groups_Id_Onenote_Notebooks_Id_Sections: return $"/groups/{GroupsId}/onenote/notebooks/{NotebooksId}/sections";
                    case ApiPath.Sites_Id_Onenote_Notebooks_Id_Sections: return $"/sites/{SitesId}/onenote/notebooks/{NotebooksId}/sections";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
            CreatedBy,
            CreatedDateTime,
            Id,
            IsDefault,
            LastModifiedBy,
            LastModifiedDateTime,
            Links,
            DisplayName,
            PagesUrl,
            Self,
            Pages,
            ParentNotebook,
            ParentSectionGroup,
        }
        public enum ApiPath
        {
            Me_Onenote_Notebooks_Id_Sections,
            Users_IdOrUserPrincipalName_Onenote_Notebooks_Id_Sections,
            Groups_Id_Onenote_Notebooks_Id_Sections,
            Sites_Id_Onenote_Notebooks_Id_Sections,
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
    public partial class NotebookListSectionsResponse : RestApiResponse
    {
        public Section[] Value { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/notebook-list-sections?view=graph-rest-1.0
        /// </summary>
        public async Task<NotebookListSectionsResponse> NotebookListSectionsAsync()
        {
            var p = new NotebookListSectionsParameter();
            return await this.SendAsync<NotebookListSectionsParameter, NotebookListSectionsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/notebook-list-sections?view=graph-rest-1.0
        /// </summary>
        public async Task<NotebookListSectionsResponse> NotebookListSectionsAsync(CancellationToken cancellationToken)
        {
            var p = new NotebookListSectionsParameter();
            return await this.SendAsync<NotebookListSectionsParameter, NotebookListSectionsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/notebook-list-sections?view=graph-rest-1.0
        /// </summary>
        public async Task<NotebookListSectionsResponse> NotebookListSectionsAsync(NotebookListSectionsParameter parameter)
        {
            return await this.SendAsync<NotebookListSectionsParameter, NotebookListSectionsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/notebook-list-sections?view=graph-rest-1.0
        /// </summary>
        public async Task<NotebookListSectionsResponse> NotebookListSectionsAsync(NotebookListSectionsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<NotebookListSectionsParameter, NotebookListSectionsResponse>(parameter, cancellationToken);
        }
    }
}
