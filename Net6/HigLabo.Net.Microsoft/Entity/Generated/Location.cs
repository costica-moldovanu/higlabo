﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/location?view=graph-rest-1.0
    /// </summary>
    public partial class Location
    {
        public PhysicalAddress? Address { get; set; }
        public OutlookGeoCoordinates? Coordinates { get; set; }
        public string DisplayName { get; set; }
        public string LocationEmailAddress { get; set; }
        public string LocationUri { get; set; }
        public LocationLocationType LocationType { get; set; }
        public string UniqueId { get; set; }
        public string UniqueIdType { get; set; }
    }
}
