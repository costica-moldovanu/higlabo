﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/recurrencerange?view=graph-rest-1.0
    /// </summary>
    public partial class RecurrenceRange
    {
        public DateOnly EndDate { get; set; }
        public Int32? NumberOfOccurrences { get; set; }
        public string RecurrenceTimeZone { get; set; }
        public DateOnly StartDate { get; set; }
        public RecurrenceRangeRecurrenceRangeType Type { get; set; }
    }
}
