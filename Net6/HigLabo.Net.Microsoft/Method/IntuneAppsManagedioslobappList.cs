﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class IntuneAppsManagedioslobappListParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
        }
        public enum ApiPath
        {
            DeviceAppManagement_MobileApps,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.DeviceAppManagement_MobileApps: return $"/deviceAppManagement/mobileApps";
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
    }
    public partial class IntuneAppsManagedioslobappListResponse : RestApiResponse
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/resources/intune-apps-managedioslobapp?view=graph-rest-1.0
        /// </summary>
        public partial class ManagedIOSLobApp
        {
            public enum ManagedIOSLobAppMobileAppPublishingState
            {
                NotPublished,
                Processing,
                Published,
            }
            public enum ManagedIOSLobAppManagedAppAvailability
            {
                Global,
                LineOfBusiness,
            }

            public string? Id { get; set; }
            public string? DisplayName { get; set; }
            public string? Description { get; set; }
            public string? Publisher { get; set; }
            public MimeContent? LargeIcon { get; set; }
            public DateTimeOffset? CreatedDateTime { get; set; }
            public DateTimeOffset? LastModifiedDateTime { get; set; }
            public bool? IsFeatured { get; set; }
            public string? PrivacyInformationUrl { get; set; }
            public string? InformationUrl { get; set; }
            public string? Owner { get; set; }
            public string? Developer { get; set; }
            public string? Notes { get; set; }
            public MobileAppPublishingState? PublishingState { get; set; }
            public ManagedAppAvailability? AppAvailability { get; set; }
            public string? Version { get; set; }
            public string? CommittedContentVersion { get; set; }
            public string? FileName { get; set; }
            public Int64? Size { get; set; }
            public string? BundleId { get; set; }
            public IosDeviceType? ApplicableDeviceType { get; set; }
            public IosMinimumOperatingSystem? MinimumSupportedOperatingSystem { get; set; }
            public DateTimeOffset? ExpirationDateTime { get; set; }
            public string? VersionNumber { get; set; }
            public string? BuildNumber { get; set; }
        }

        public ManagedIOSLobApp[] Value { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-apps-managedioslobapp-list?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneAppsManagedioslobappListResponse> IntuneAppsManagedioslobappListAsync()
        {
            var p = new IntuneAppsManagedioslobappListParameter();
            return await this.SendAsync<IntuneAppsManagedioslobappListParameter, IntuneAppsManagedioslobappListResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-apps-managedioslobapp-list?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneAppsManagedioslobappListResponse> IntuneAppsManagedioslobappListAsync(CancellationToken cancellationToken)
        {
            var p = new IntuneAppsManagedioslobappListParameter();
            return await this.SendAsync<IntuneAppsManagedioslobappListParameter, IntuneAppsManagedioslobappListResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-apps-managedioslobapp-list?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneAppsManagedioslobappListResponse> IntuneAppsManagedioslobappListAsync(IntuneAppsManagedioslobappListParameter parameter)
        {
            return await this.SendAsync<IntuneAppsManagedioslobappListParameter, IntuneAppsManagedioslobappListResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-apps-managedioslobapp-list?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneAppsManagedioslobappListResponse> IntuneAppsManagedioslobappListAsync(IntuneAppsManagedioslobappListParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<IntuneAppsManagedioslobappListParameter, IntuneAppsManagedioslobappListResponse>(parameter, cancellationToken);
        }
    }
}
