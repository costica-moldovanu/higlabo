﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/intune-deviceconfig-androidworkprofilecompliancepolicy?view=graph-rest-1.0
    /// </summary>
    public partial class AndroidWorkProfileCompliancePolicy
    {
        public enum AndroidWorkProfileCompliancePolicyAndroidRequiredPasswordType
        {
            DeviceDefault,
            Alphabetic,
            Alphanumeric,
            AlphanumericWithSymbols,
            LowSecurityBiometric,
            Numeric,
            NumericComplex,
            Any,
        }
        public enum AndroidWorkProfileCompliancePolicyDeviceThreatProtectionLevel
        {
            Unavailable,
            Secured,
            Low,
            Medium,
            High,
            NotSet,
        }

        public string? Id { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? Description { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string? DisplayName { get; set; }
        public Int32? Version { get; set; }
        public bool? PasswordRequired { get; set; }
        public Int32? PasswordMinimumLength { get; set; }
        public AndroidRequiredPasswordType? PasswordRequiredType { get; set; }
        public Int32? PasswordMinutesOfInactivityBeforeLock { get; set; }
        public Int32? PasswordExpirationDays { get; set; }
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
        public bool? SecurityPreventInstallAppsFromUnknownSources { get; set; }
        public bool? SecurityDisableUsbDebugging { get; set; }
        public bool? SecurityRequireVerifyApps { get; set; }
        public bool? DeviceThreatProtectionEnabled { get; set; }
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel { get; set; }
        public bool? SecurityBlockJailbrokenDevices { get; set; }
        public string? OsMinimumVersion { get; set; }
        public string? OsMaximumVersion { get; set; }
        public string? MinAndroidSecurityPatchLevel { get; set; }
        public bool? StorageRequireEncryption { get; set; }
        public bool? SecurityRequireSafetyNetAttestationBasicIntegrity { get; set; }
        public bool? SecurityRequireSafetyNetAttestationCertifiedDevice { get; set; }
        public bool? SecurityRequireGooglePlayServices { get; set; }
        public bool? SecurityRequireUpToDateSecurityProviders { get; set; }
        public bool? SecurityRequireCompanyPortalAppIntegrity { get; set; }
    }
}
