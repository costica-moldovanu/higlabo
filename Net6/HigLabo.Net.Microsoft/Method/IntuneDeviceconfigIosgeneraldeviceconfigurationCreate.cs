﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameter : IRestApiParameter
    {
        public enum IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameterAppListType
        {
            None,
            AppsInListCompliant,
            AppsNotInListCompliant,
        }
        public enum IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameterRatingAppsType
        {
            AllAllowed,
            AllBlocked,
            AgesAbove4,
            AgesAbove9,
            AgesAbove12,
            AgesAbove17,
        }
        public enum IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameterRequiredPasswordType
        {
            DeviceDefault,
            Alphanumeric,
            Numeric,
        }
        public enum IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameterWebBrowserCookieSettings
        {
            BrowserDefault,
            BlockAlways,
            AllowCurrentWebSite,
            AllowFromWebsitesVisited,
            AllowAlways,
        }
        public enum ApiPath
        {
            DeviceManagement_DeviceConfigurations,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.DeviceManagement_DeviceConfigurations: return $"/deviceManagement/deviceConfigurations";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.Path);
                }
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string? Id { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? Description { get; set; }
        public string? DisplayName { get; set; }
        public Int32? Version { get; set; }
        public bool? AccountBlockModification { get; set; }
        public bool? ActivationLockAllowWhenSupervised { get; set; }
        public bool? AirDropBlocked { get; set; }
        public bool? AirDropForceUnmanagedDropTarget { get; set; }
        public bool? AirPlayForcePairingPasswordForOutgoingRequests { get; set; }
        public bool? AppleWatchBlockPairing { get; set; }
        public bool? AppleWatchForceWristDetection { get; set; }
        public bool? AppleNewsBlocked { get; set; }
        public AppListItem[]? AppsSingleAppModeList { get; set; }
        public AppListItem[]? AppsVisibilityList { get; set; }
        public IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameterAppListType AppsVisibilityListType { get; set; }
        public bool? AppStoreBlockAutomaticDownloads { get; set; }
        public bool? AppStoreBlocked { get; set; }
        public bool? AppStoreBlockInAppPurchases { get; set; }
        public bool? AppStoreBlockUIAppInstallation { get; set; }
        public bool? AppStoreRequirePassword { get; set; }
        public bool? BluetoothBlockModification { get; set; }
        public bool? CameraBlocked { get; set; }
        public bool? CellularBlockDataRoaming { get; set; }
        public bool? CellularBlockGlobalBackgroundFetchWhileRoaming { get; set; }
        public bool? CellularBlockPerAppDataModification { get; set; }
        public bool? CellularBlockPersonalHotspot { get; set; }
        public bool? CellularBlockVoiceRoaming { get; set; }
        public bool? CertificatesBlockUntrustedTlsCertificates { get; set; }
        public bool? ClassroomAppBlockRemoteScreenObservation { get; set; }
        public bool? ClassroomAppForceUnpromptedScreenObservation { get; set; }
        public AppListItem[]? CompliantAppsList { get; set; }
        public IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameterAppListType CompliantAppListType { get; set; }
        public bool? ConfigurationProfileBlockChanges { get; set; }
        public bool? DefinitionLookupBlocked { get; set; }
        public bool? DeviceBlockEnableRestrictions { get; set; }
        public bool? DeviceBlockEraseContentAndSettings { get; set; }
        public bool? DeviceBlockNameModification { get; set; }
        public bool? DiagnosticDataBlockSubmission { get; set; }
        public bool? DiagnosticDataBlockSubmissionModification { get; set; }
        public bool? DocumentsBlockManagedDocumentsInUnmanagedApps { get; set; }
        public bool? DocumentsBlockUnmanagedDocumentsInManagedApps { get; set; }
        public String[]? EmailInDomainSuffixes { get; set; }
        public bool? EnterpriseAppBlockTrust { get; set; }
        public bool? EnterpriseAppBlockTrustModification { get; set; }
        public bool? FaceTimeBlocked { get; set; }
        public bool? FindMyFriendsBlocked { get; set; }
        public bool? GamingBlockGameCenterFriends { get; set; }
        public bool? GamingBlockMultiplayer { get; set; }
        public bool? GameCenterBlocked { get; set; }
        public bool? HostPairingBlocked { get; set; }
        public bool? IBooksStoreBlocked { get; set; }
        public bool? IBooksStoreBlockErotica { get; set; }
        public bool? ICloudBlockActivityContinuation { get; set; }
        public bool? ICloudBlockBackup { get; set; }
        public bool? ICloudBlockDocumentSync { get; set; }
        public bool? ICloudBlockManagedAppsSync { get; set; }
        public bool? ICloudBlockPhotoLibrary { get; set; }
        public bool? ICloudBlockPhotoStreamSync { get; set; }
        public bool? ICloudBlockSharedPhotoStream { get; set; }
        public bool? ICloudRequireEncryptedBackup { get; set; }
        public bool? ITunesBlockExplicitContent { get; set; }
        public bool? ITunesBlockMusicService { get; set; }
        public bool? ITunesBlockRadio { get; set; }
        public bool? KeyboardBlockAutoCorrect { get; set; }
        public bool? KeyboardBlockDictation { get; set; }
        public bool? KeyboardBlockPredictive { get; set; }
        public bool? KeyboardBlockShortcuts { get; set; }
        public bool? KeyboardBlockSpellCheck { get; set; }
        public bool? KioskModeAllowAssistiveSpeak { get; set; }
        public bool? KioskModeAllowAssistiveTouchSettings { get; set; }
        public bool? KioskModeAllowAutoLock { get; set; }
        public bool? KioskModeAllowColorInversionSettings { get; set; }
        public bool? KioskModeAllowRingerSwitch { get; set; }
        public bool? KioskModeAllowScreenRotation { get; set; }
        public bool? KioskModeAllowSleepButton { get; set; }
        public bool? KioskModeAllowTouchscreen { get; set; }
        public bool? KioskModeAllowVoiceOverSettings { get; set; }
        public bool? KioskModeAllowVolumeButtons { get; set; }
        public bool? KioskModeAllowZoomSettings { get; set; }
        public string? KioskModeAppStoreUrl { get; set; }
        public string? KioskModeBuiltInAppId { get; set; }
        public bool? KioskModeRequireAssistiveTouch { get; set; }
        public bool? KioskModeRequireColorInversion { get; set; }
        public bool? KioskModeRequireMonoAudio { get; set; }
        public bool? KioskModeRequireVoiceOver { get; set; }
        public bool? KioskModeRequireZoom { get; set; }
        public string? KioskModeManagedAppId { get; set; }
        public bool? LockScreenBlockControlCenter { get; set; }
        public bool? LockScreenBlockNotificationView { get; set; }
        public bool? LockScreenBlockPassbook { get; set; }
        public bool? LockScreenBlockTodayView { get; set; }
        public MediaContentRatingAustralia? MediaContentRatingAustralia { get; set; }
        public MediaContentRatingCanada? MediaContentRatingCanada { get; set; }
        public MediaContentRatingFrance? MediaContentRatingFrance { get; set; }
        public MediaContentRatingGermany? MediaContentRatingGermany { get; set; }
        public MediaContentRatingIreland? MediaContentRatingIreland { get; set; }
        public MediaContentRatingJapan? MediaContentRatingJapan { get; set; }
        public MediaContentRatingNewZealand? MediaContentRatingNewZealand { get; set; }
        public MediaContentRatingUnitedKingdom? MediaContentRatingUnitedKingdom { get; set; }
        public MediaContentRatingUnitedStates? MediaContentRatingUnitedStates { get; set; }
        public IosNetworkUsageRule[]? NetworkUsageRules { get; set; }
        public IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameterRatingAppsType MediaContentRatingApps { get; set; }
        public bool? MessagesBlocked { get; set; }
        public bool? NotificationsBlockSettingsModification { get; set; }
        public bool? PasscodeBlockFingerprintUnlock { get; set; }
        public bool? PasscodeBlockFingerprintModification { get; set; }
        public bool? PasscodeBlockModification { get; set; }
        public bool? PasscodeBlockSimple { get; set; }
        public Int32? PasscodeExpirationDays { get; set; }
        public Int32? PasscodeMinimumLength { get; set; }
        public Int32? PasscodeMinutesOfInactivityBeforeLock { get; set; }
        public Int32? PasscodeMinutesOfInactivityBeforeScreenTimeout { get; set; }
        public Int32? PasscodeMinimumCharacterSetCount { get; set; }
        public Int32? PasscodePreviousPasscodeBlockCount { get; set; }
        public Int32? PasscodeSignInFailureCountBeforeWipe { get; set; }
        public IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameterRequiredPasswordType PasscodeRequiredType { get; set; }
        public bool? PasscodeRequired { get; set; }
        public bool? PodcastsBlocked { get; set; }
        public bool? SafariBlockAutofill { get; set; }
        public bool? SafariBlockJavaScript { get; set; }
        public bool? SafariBlockPopups { get; set; }
        public bool? SafariBlocked { get; set; }
        public IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameterWebBrowserCookieSettings SafariCookieSettings { get; set; }
        public String[]? SafariManagedDomains { get; set; }
        public String[]? SafariPasswordAutoFillDomains { get; set; }
        public bool? SafariRequireFraudWarning { get; set; }
        public bool? ScreenCaptureBlocked { get; set; }
        public bool? SiriBlocked { get; set; }
        public bool? SiriBlockedWhenLocked { get; set; }
        public bool? SiriBlockUserGeneratedContent { get; set; }
        public bool? SiriRequireProfanityFilter { get; set; }
        public bool? SpotlightBlockInternetResults { get; set; }
        public bool? VoiceDialingBlocked { get; set; }
        public bool? WallpaperBlockModification { get; set; }
        public bool? WiFiConnectOnlyToConfiguredNetworks { get; set; }
    }
    public partial class IntuneDeviceconfigIosgeneraldeviceconfigurationCreateResponse : RestApiResponse
    {
        public enum IosGeneralDeviceConfigurationAppListType
        {
            None,
            AppsInListCompliant,
            AppsNotInListCompliant,
        }
        public enum IosGeneralDeviceConfigurationRatingAppsType
        {
            AllAllowed,
            AllBlocked,
            AgesAbove4,
            AgesAbove9,
            AgesAbove12,
            AgesAbove17,
        }
        public enum IosGeneralDeviceConfigurationRequiredPasswordType
        {
            DeviceDefault,
            Alphanumeric,
            Numeric,
        }
        public enum IosGeneralDeviceConfigurationWebBrowserCookieSettings
        {
            BrowserDefault,
            BlockAlways,
            AllowCurrentWebSite,
            AllowFromWebsitesVisited,
            AllowAlways,
        }

        public string? Id { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? Description { get; set; }
        public string? DisplayName { get; set; }
        public Int32? Version { get; set; }
        public bool? AccountBlockModification { get; set; }
        public bool? ActivationLockAllowWhenSupervised { get; set; }
        public bool? AirDropBlocked { get; set; }
        public bool? AirDropForceUnmanagedDropTarget { get; set; }
        public bool? AirPlayForcePairingPasswordForOutgoingRequests { get; set; }
        public bool? AppleWatchBlockPairing { get; set; }
        public bool? AppleWatchForceWristDetection { get; set; }
        public bool? AppleNewsBlocked { get; set; }
        public AppListItem[]? AppsSingleAppModeList { get; set; }
        public AppListItem[]? AppsVisibilityList { get; set; }
        public AppListType? AppsVisibilityListType { get; set; }
        public bool? AppStoreBlockAutomaticDownloads { get; set; }
        public bool? AppStoreBlocked { get; set; }
        public bool? AppStoreBlockInAppPurchases { get; set; }
        public bool? AppStoreBlockUIAppInstallation { get; set; }
        public bool? AppStoreRequirePassword { get; set; }
        public bool? BluetoothBlockModification { get; set; }
        public bool? CameraBlocked { get; set; }
        public bool? CellularBlockDataRoaming { get; set; }
        public bool? CellularBlockGlobalBackgroundFetchWhileRoaming { get; set; }
        public bool? CellularBlockPerAppDataModification { get; set; }
        public bool? CellularBlockPersonalHotspot { get; set; }
        public bool? CellularBlockVoiceRoaming { get; set; }
        public bool? CertificatesBlockUntrustedTlsCertificates { get; set; }
        public bool? ClassroomAppBlockRemoteScreenObservation { get; set; }
        public bool? ClassroomAppForceUnpromptedScreenObservation { get; set; }
        public AppListItem[]? CompliantAppsList { get; set; }
        public AppListType? CompliantAppListType { get; set; }
        public bool? ConfigurationProfileBlockChanges { get; set; }
        public bool? DefinitionLookupBlocked { get; set; }
        public bool? DeviceBlockEnableRestrictions { get; set; }
        public bool? DeviceBlockEraseContentAndSettings { get; set; }
        public bool? DeviceBlockNameModification { get; set; }
        public bool? DiagnosticDataBlockSubmission { get; set; }
        public bool? DiagnosticDataBlockSubmissionModification { get; set; }
        public bool? DocumentsBlockManagedDocumentsInUnmanagedApps { get; set; }
        public bool? DocumentsBlockUnmanagedDocumentsInManagedApps { get; set; }
        public String[]? EmailInDomainSuffixes { get; set; }
        public bool? EnterpriseAppBlockTrust { get; set; }
        public bool? EnterpriseAppBlockTrustModification { get; set; }
        public bool? FaceTimeBlocked { get; set; }
        public bool? FindMyFriendsBlocked { get; set; }
        public bool? GamingBlockGameCenterFriends { get; set; }
        public bool? GamingBlockMultiplayer { get; set; }
        public bool? GameCenterBlocked { get; set; }
        public bool? HostPairingBlocked { get; set; }
        public bool? IBooksStoreBlocked { get; set; }
        public bool? IBooksStoreBlockErotica { get; set; }
        public bool? ICloudBlockActivityContinuation { get; set; }
        public bool? ICloudBlockBackup { get; set; }
        public bool? ICloudBlockDocumentSync { get; set; }
        public bool? ICloudBlockManagedAppsSync { get; set; }
        public bool? ICloudBlockPhotoLibrary { get; set; }
        public bool? ICloudBlockPhotoStreamSync { get; set; }
        public bool? ICloudBlockSharedPhotoStream { get; set; }
        public bool? ICloudRequireEncryptedBackup { get; set; }
        public bool? ITunesBlockExplicitContent { get; set; }
        public bool? ITunesBlockMusicService { get; set; }
        public bool? ITunesBlockRadio { get; set; }
        public bool? KeyboardBlockAutoCorrect { get; set; }
        public bool? KeyboardBlockDictation { get; set; }
        public bool? KeyboardBlockPredictive { get; set; }
        public bool? KeyboardBlockShortcuts { get; set; }
        public bool? KeyboardBlockSpellCheck { get; set; }
        public bool? KioskModeAllowAssistiveSpeak { get; set; }
        public bool? KioskModeAllowAssistiveTouchSettings { get; set; }
        public bool? KioskModeAllowAutoLock { get; set; }
        public bool? KioskModeAllowColorInversionSettings { get; set; }
        public bool? KioskModeAllowRingerSwitch { get; set; }
        public bool? KioskModeAllowScreenRotation { get; set; }
        public bool? KioskModeAllowSleepButton { get; set; }
        public bool? KioskModeAllowTouchscreen { get; set; }
        public bool? KioskModeAllowVoiceOverSettings { get; set; }
        public bool? KioskModeAllowVolumeButtons { get; set; }
        public bool? KioskModeAllowZoomSettings { get; set; }
        public string? KioskModeAppStoreUrl { get; set; }
        public string? KioskModeBuiltInAppId { get; set; }
        public bool? KioskModeRequireAssistiveTouch { get; set; }
        public bool? KioskModeRequireColorInversion { get; set; }
        public bool? KioskModeRequireMonoAudio { get; set; }
        public bool? KioskModeRequireVoiceOver { get; set; }
        public bool? KioskModeRequireZoom { get; set; }
        public string? KioskModeManagedAppId { get; set; }
        public bool? LockScreenBlockControlCenter { get; set; }
        public bool? LockScreenBlockNotificationView { get; set; }
        public bool? LockScreenBlockPassbook { get; set; }
        public bool? LockScreenBlockTodayView { get; set; }
        public MediaContentRatingAustralia? MediaContentRatingAustralia { get; set; }
        public MediaContentRatingCanada? MediaContentRatingCanada { get; set; }
        public MediaContentRatingFrance? MediaContentRatingFrance { get; set; }
        public MediaContentRatingGermany? MediaContentRatingGermany { get; set; }
        public MediaContentRatingIreland? MediaContentRatingIreland { get; set; }
        public MediaContentRatingJapan? MediaContentRatingJapan { get; set; }
        public MediaContentRatingNewZealand? MediaContentRatingNewZealand { get; set; }
        public MediaContentRatingUnitedKingdom? MediaContentRatingUnitedKingdom { get; set; }
        public MediaContentRatingUnitedStates? MediaContentRatingUnitedStates { get; set; }
        public IosNetworkUsageRule[]? NetworkUsageRules { get; set; }
        public RatingAppsType? MediaContentRatingApps { get; set; }
        public bool? MessagesBlocked { get; set; }
        public bool? NotificationsBlockSettingsModification { get; set; }
        public bool? PasscodeBlockFingerprintUnlock { get; set; }
        public bool? PasscodeBlockFingerprintModification { get; set; }
        public bool? PasscodeBlockModification { get; set; }
        public bool? PasscodeBlockSimple { get; set; }
        public Int32? PasscodeExpirationDays { get; set; }
        public Int32? PasscodeMinimumLength { get; set; }
        public Int32? PasscodeMinutesOfInactivityBeforeLock { get; set; }
        public Int32? PasscodeMinutesOfInactivityBeforeScreenTimeout { get; set; }
        public Int32? PasscodeMinimumCharacterSetCount { get; set; }
        public Int32? PasscodePreviousPasscodeBlockCount { get; set; }
        public Int32? PasscodeSignInFailureCountBeforeWipe { get; set; }
        public RequiredPasswordType? PasscodeRequiredType { get; set; }
        public bool? PasscodeRequired { get; set; }
        public bool? PodcastsBlocked { get; set; }
        public bool? SafariBlockAutofill { get; set; }
        public bool? SafariBlockJavaScript { get; set; }
        public bool? SafariBlockPopups { get; set; }
        public bool? SafariBlocked { get; set; }
        public WebBrowserCookieSettings? SafariCookieSettings { get; set; }
        public String[]? SafariManagedDomains { get; set; }
        public String[]? SafariPasswordAutoFillDomains { get; set; }
        public bool? SafariRequireFraudWarning { get; set; }
        public bool? ScreenCaptureBlocked { get; set; }
        public bool? SiriBlocked { get; set; }
        public bool? SiriBlockedWhenLocked { get; set; }
        public bool? SiriBlockUserGeneratedContent { get; set; }
        public bool? SiriRequireProfanityFilter { get; set; }
        public bool? SpotlightBlockInternetResults { get; set; }
        public bool? VoiceDialingBlocked { get; set; }
        public bool? WallpaperBlockModification { get; set; }
        public bool? WiFiConnectOnlyToConfiguredNetworks { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-deviceconfig-iosgeneraldeviceconfiguration-create?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneDeviceconfigIosgeneraldeviceconfigurationCreateResponse> IntuneDeviceconfigIosgeneraldeviceconfigurationCreateAsync()
        {
            var p = new IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameter();
            return await this.SendAsync<IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameter, IntuneDeviceconfigIosgeneraldeviceconfigurationCreateResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-deviceconfig-iosgeneraldeviceconfiguration-create?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneDeviceconfigIosgeneraldeviceconfigurationCreateResponse> IntuneDeviceconfigIosgeneraldeviceconfigurationCreateAsync(CancellationToken cancellationToken)
        {
            var p = new IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameter();
            return await this.SendAsync<IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameter, IntuneDeviceconfigIosgeneraldeviceconfigurationCreateResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-deviceconfig-iosgeneraldeviceconfiguration-create?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneDeviceconfigIosgeneraldeviceconfigurationCreateResponse> IntuneDeviceconfigIosgeneraldeviceconfigurationCreateAsync(IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameter parameter)
        {
            return await this.SendAsync<IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameter, IntuneDeviceconfigIosgeneraldeviceconfigurationCreateResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-deviceconfig-iosgeneraldeviceconfiguration-create?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneDeviceconfigIosgeneraldeviceconfigurationCreateResponse> IntuneDeviceconfigIosgeneraldeviceconfigurationCreateAsync(IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<IntuneDeviceconfigIosgeneraldeviceconfigurationCreateParameter, IntuneDeviceconfigIosgeneraldeviceconfigurationCreateResponse>(parameter, cancellationToken);
        }
    }
}
