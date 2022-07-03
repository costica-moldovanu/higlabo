﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/educationassignment?view=graph-rest-1.0
    /// </summary>
    public partial class EducationAssignment
    {
        public string Id { get; set; }
        public string AddedStudentAction { get; set; }
        public EducationAssignmentEducationAddToCalendarOptions AddToCalendarAction { get; set; }
        public bool AllowLateSubmissions { get; set; }
        public bool AllowStudentsToAddResourcesToSubmission { get; set; }
        public DateTimeOffset AssignDateTime { get; set; }
        public EducationAssignmentRecipient? AssignTo { get; set; }
        public DateTimeOffset AssignedDateTime { get; set; }
        public string ClassId { get; set; }
        public DateTimeOffset CloseDateTime { get; set; }
        public IdentitySet? CreatedBy { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public string DisplayName { get; set; }
        public DateTimeOffset DueDateTime { get; set; }
        public EducationAssignmentGradeType? Grading { get; set; }
        public ItemBody? Instructions { get; set; }
        public IdentitySet? LastModifiedBy { get; set; }
        public DateTimeOffset LastModifiedDateTime { get; set; }
        public string NotificationChannelUrl { get; set; }
        public EducationAssignmentString Status { get; set; }
        public String? WebUrl { get; set; }
        public String? ResourcesFolderUrl { get; set; }
    }
}
