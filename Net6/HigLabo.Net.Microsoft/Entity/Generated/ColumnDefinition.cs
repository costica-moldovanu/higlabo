﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/columndefinition?view=graph-rest-1.0
    /// </summary>
    public partial class ColumnDefinition
    {
        public String? ColumnGroup { get; set; }
        public String? Description { get; set; }
        public String? DisplayName { get; set; }
        public bool EnforceUniqueValues { get; set; }
        public bool Hidden { get; set; }
        public String? Id { get; set; }
        public bool Indexed { get; set; }
        public String? Name { get; set; }
        public bool ReadOnly { get; set; }
        public bool Required { get; set; }
        public BooleanColumn? Boolean { get; set; }
        public CalculatedColumn? Calculated { get; set; }
        public ChoiceColumn? Choice { get; set; }
        public CurrencyColumn? Currency { get; set; }
        public DateTimeColumn? DateTime { get; set; }
        public DefaultColumnValue? DefaultValue { get; set; }
        public GeolocationColumn? Geolocation { get; set; }
        public LookupColumn? Lookup { get; set; }
        public NumberColumn? Number { get; set; }
        public PersonOrGroupColumn? PersonOrGroup { get; set; }
        public TextColumn? Text { get; set; }
        public bool IsDeletable { get; set; }
        public bool PropagateChanges { get; set; }
        public bool IsReorderable { get; set; }
        public bool IsSealed { get; set; }
        public ColumnValidation? Validation { get; set; }
        public HyperlinkOrPictureColumn? HyperlinkOrPicture { get; set; }
        public TermColumn? Term { get; set; }
        public ContentTypeInfo? SourceContentType { get; set; }
        public ThumbnailColumn? Thumbnail { get; set; }
        public string Type { get; set; }
        public ContentApprovalStatusColumn? ContentApprovalStatus { get; set; }
    }
}
