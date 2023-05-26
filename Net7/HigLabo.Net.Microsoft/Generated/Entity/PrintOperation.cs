﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/resources/printoperation?view=graph-rest-1.0
    /// </summary>
    public partial class PrintOperation
    {
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? Id { get; set; }
        public PrintOperationStatus? Status { get; set; }
    }
}
