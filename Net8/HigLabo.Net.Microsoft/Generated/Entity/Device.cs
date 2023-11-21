﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/resources/device?view=graph-rest-1.0
    /// </summary>
    public partial class Device
    {
        public enum DeviceDeviceProfileType
        {
            RegisteredDevice,
            SecureVM,
            Printer,
            Shared,
            IoT,
        }

        public bool? AccountEnabled { get; set; }
        public AlternativeSecurityId[]? AlternativeSecurityIds { get; set; }
        public DateTimeOffset? ApproximateLastSignInDateTime { get; set; }
        public DateTimeOffset? ComplianceExpirationDateTime { get; set; }
        public string? DeviceCategory { get; set; }
        public string? DeviceId { get; set; }
        public string? DeviceMetadata { get; set; }
        public string? DeviceOwnership { get; set; }
        public Int32? DeviceVersion { get; set; }
        public string? DisplayName { get; set; }
        public string? EnrollmentProfileName { get; set; }
        public OnPremisesExtensionAttributes? ExtensionAttributes { get; set; }
        public string? Id { get; set; }
        public bool? IsCompliant { get; set; }
        public bool? IsManaged { get; set; }
        public string? Manufacturer { get; set; }
        public string? MdmAppId { get; set; }
        public string? Model { get; set; }
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
        public bool? OnPremisesSyncEnabled { get; set; }
        public string? OperatingSystem { get; set; }
        public string? OperatingSystemVersion { get; set; }
        public String[]? PhysicalIds { get; set; }
        public DeviceDeviceProfileType ProfileType { get; set; }
        public DateTimeOffset? RegistrationDateTime { get; set; }
        public String[]? SystemLabels { get; set; }
        public string? TrustType { get; set; }
        public Extension[]? Extensions { get; set; }
        public DirectoryObject[]? MemberOf { get; set; }
        public DirectoryObject[]? RegisteredOwners { get; set; }
        public DirectoryObject[]? RegisteredUsers { get; set; }
        public DirectoryObject[]? TransitiveMemberOf { get; set; }
    }
}
