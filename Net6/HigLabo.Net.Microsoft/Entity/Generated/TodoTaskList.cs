﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/todotasklist?view=graph-rest-1.0
    /// </summary>
    public partial class TodoTaskList
    {
        public string DisplayName { get; set; }
        public string Id { get; set; }
        public bool IsOwner { get; set; }
        public bool IsShared { get; set; }
        public TodoTaskListWellknownListName WellknownListName { get; set; }
    }
}
