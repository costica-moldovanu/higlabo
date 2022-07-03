﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/printdocument?view=graph-rest-1.0
    /// </summary>
    public partial class PrintDocument
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string ContentType { get; set; }
        public Int64? Size { get; set; }
    }
}
