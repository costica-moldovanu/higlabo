﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/datetimecolumn?view=graph-rest-1.0
    /// </summary>
    public partial class DateTimeColumn
    {
        public String? DisplayAs { get; set; }
        public String? Format { get; set; }
    }
}
