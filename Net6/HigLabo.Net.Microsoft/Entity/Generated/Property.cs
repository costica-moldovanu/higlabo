﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/externalconnectors-property?view=graph-rest-1.0
    /// </summary>
    public partial class Property
    {
        public String[] Aliases { get; set; }
        public bool IsQueryable { get; set; }
        public bool IsRefinable { get; set; }
        public bool IsRetrievable { get; set; }
        public bool IsSearchable { get; set; }
        public PropertyExternalConnectorsLabel Labels { get; set; }
        public string Name { get; set; }
        public PropertyExternalConnectorsPropertyType Type { get; set; }
    }
}
