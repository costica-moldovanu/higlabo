﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class IntuneMamAndroidmanagedappprotectionGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
        }
        public enum ApiPath
        {
            DeviceAppManagement_AndroidManagedAppProtections_AndroidManagedAppProtectionId,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.DeviceAppManagement_AndroidManagedAppProtections_AndroidManagedAppProtectionId: return $"/deviceAppManagement/androidManagedAppProtections/{AndroidManagedAppProtectionId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "GET";
        public QueryParameter<Field> Query { get; set; } = new QueryParameter<Field>();
        IQueryParameter IQueryParameterProperty.Query
        {
            get
            {
                return this.Query;
            }
        }
        public string AndroidManagedAppProtectionId { get; set; }
    }
    public partial class IntuneMamAndroidmanagedappprotectionGetResponse : RestApiResponse
    {
        public enum AndroidManagedAppProtectionManagedAppDataTransferLevel
        {
            AllApps,
            ManagedApps,
            None,
        }
        public enum AndroidManagedAppProtectionManagedAppClipboardSharingLevel
        {
            AllApps,
            ManagedAppsWithPasteIn,
            ManagedApps,
            Blocked,
        }
        public enum AndroidManagedAppProtectionManagedAppPinCharacterSet
        {
            Numeric,
            AlphanumericAndSymbol,
        }
        public enum AndroidManagedAppProtectionManagedBrowserType
        {
            NotConfigured,
            MicrosoftEdge,
        }

        public string? DisplayName { get; set; }
        public string? Description { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string? Id { get; set; }
        public string? Version { get; set; }
        public string? PeriodOfflineBeforeAccessCheck { get; set; }
        public string? PeriodOnlineBeforeAccessCheck { get; set; }
        public ManagedAppDataTransferLevel? AllowedInboundDataTransferSources { get; set; }
        public ManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations { get; set; }
        public bool? OrganizationalCredentialsRequired { get; set; }
        public ManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel { get; set; }
        public bool? DataBackupBlocked { get; set; }
        public bool? DeviceComplianceRequired { get; set; }
        public bool? ManagedBrowserToOpenLinksRequired { get; set; }
        public bool? SaveAsBlocked { get; set; }
        public string? PeriodOfflineBeforeWipeIsEnforced { get; set; }
        public bool? PinRequired { get; set; }
        public Int32? MaximumPinRetries { get; set; }
        public bool? SimplePinBlocked { get; set; }
        public Int32? MinimumPinLength { get; set; }
        public ManagedAppPinCharacterSet? PinCharacterSet { get; set; }
        public string? PeriodBeforePinReset { get; set; }
        public ManagedAppDataStorageLocation[]? AllowedDataStorageLocations { get; set; }
        public bool? ContactSyncBlocked { get; set; }
        public bool? PrintBlocked { get; set; }
        public bool? FingerprintBlocked { get; set; }
        public bool? DisableAppPinIfDevicePinIsSet { get; set; }
        public string? MinimumRequiredOsVersion { get; set; }
        public string? MinimumWarningOsVersion { get; set; }
        public string? MinimumRequiredAppVersion { get; set; }
        public string? MinimumWarningAppVersion { get; set; }
        public ManagedBrowserType? ManagedBrowser { get; set; }
        public bool? IsAssigned { get; set; }
        public bool? ScreenCaptureBlocked { get; set; }
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }
        public bool? EncryptAppData { get; set; }
        public Int32? DeployedAppCount { get; set; }
        public string? MinimumRequiredPatchVersion { get; set; }
        public string? MinimumWarningPatchVersion { get; set; }
        public string? CustomBrowserPackageId { get; set; }
        public string? CustomBrowserDisplayName { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-mam-androidmanagedappprotection-get?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneMamAndroidmanagedappprotectionGetResponse> IntuneMamAndroidmanagedappprotectionGetAsync()
        {
            var p = new IntuneMamAndroidmanagedappprotectionGetParameter();
            return await this.SendAsync<IntuneMamAndroidmanagedappprotectionGetParameter, IntuneMamAndroidmanagedappprotectionGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-mam-androidmanagedappprotection-get?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneMamAndroidmanagedappprotectionGetResponse> IntuneMamAndroidmanagedappprotectionGetAsync(CancellationToken cancellationToken)
        {
            var p = new IntuneMamAndroidmanagedappprotectionGetParameter();
            return await this.SendAsync<IntuneMamAndroidmanagedappprotectionGetParameter, IntuneMamAndroidmanagedappprotectionGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-mam-androidmanagedappprotection-get?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneMamAndroidmanagedappprotectionGetResponse> IntuneMamAndroidmanagedappprotectionGetAsync(IntuneMamAndroidmanagedappprotectionGetParameter parameter)
        {
            return await this.SendAsync<IntuneMamAndroidmanagedappprotectionGetParameter, IntuneMamAndroidmanagedappprotectionGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-mam-androidmanagedappprotection-get?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneMamAndroidmanagedappprotectionGetResponse> IntuneMamAndroidmanagedappprotectionGetAsync(IntuneMamAndroidmanagedappprotectionGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<IntuneMamAndroidmanagedappprotectionGetParameter, IntuneMamAndroidmanagedappprotectionGetResponse>(parameter, cancellationToken);
        }
    }
}
