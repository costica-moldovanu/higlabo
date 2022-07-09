﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/printdocumentuploadproperties?view=graph-rest-1.0
    /// </summary>
    public partial class PrintDocumentUploadProperties
    {
        public string? ContentType { get; set; }
        public string? DocumentName { get; set; }
        public Int64? Size { get; set; }
    }
}
