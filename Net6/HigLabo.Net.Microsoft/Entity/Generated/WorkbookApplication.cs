﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/workbookapplication?view=graph-rest-1.0
    /// </summary>
    public partial class WorkbookApplication
    {
        public WorkbookApplicationString CalculationMode { get; set; }
    }
}
