﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class IntuneEnrollmentWindowsautopilotdeviceidentityGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
        }
        public enum ApiPath
        {
            DeviceManagement_WindowsAutopilotDeviceIdentities_WindowsAutopilotDeviceIdentityId,
        }

        public ApiPath Path { get; set; }
        string IRestApiParameter.ApiPath
        {
            get
            {
                switch (this.Path)
                {
                    case ApiPath.DeviceManagement_WindowsAutopilotDeviceIdentities_WindowsAutopilotDeviceIdentityId: return $"/deviceManagement/windowsAutopilotDeviceIdentities/{WindowsAutopilotDeviceIdentityId}";
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
        public string WindowsAutopilotDeviceIdentityId { get; set; }
    }
    public partial class IntuneEnrollmentWindowsautopilotdeviceidentityGetResponse : RestApiResponse
    {
        public enum WindowsAutopilotDeviceIdentityEnrollmentState
        {
            Unknown,
            Enrolled,
            PendingReset,
            Failed,
            NotContacted,
        }

        public string? Id { get; set; }
        public string? GroupTag { get; set; }
        public string? PurchaseOrderIdentifier { get; set; }
        public string? SerialNumber { get; set; }
        public string? ProductKey { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public EnrollmentState? EnrollmentState { get; set; }
        public DateTimeOffset? LastContactedDateTime { get; set; }
        public string? AddressableUserName { get; set; }
        public string? UserPrincipalName { get; set; }
        public string? ResourceName { get; set; }
        public string? SkuNumber { get; set; }
        public string? SystemFamily { get; set; }
        public string? AzureActiveDirectoryDeviceId { get; set; }
        public string? ManagedDeviceId { get; set; }
        public string? DisplayName { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-enrollment-windowsautopilotdeviceidentity-get?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneEnrollmentWindowsautopilotdeviceidentityGetResponse> IntuneEnrollmentWindowsautopilotdeviceidentityGetAsync()
        {
            var p = new IntuneEnrollmentWindowsautopilotdeviceidentityGetParameter();
            return await this.SendAsync<IntuneEnrollmentWindowsautopilotdeviceidentityGetParameter, IntuneEnrollmentWindowsautopilotdeviceidentityGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-enrollment-windowsautopilotdeviceidentity-get?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneEnrollmentWindowsautopilotdeviceidentityGetResponse> IntuneEnrollmentWindowsautopilotdeviceidentityGetAsync(CancellationToken cancellationToken)
        {
            var p = new IntuneEnrollmentWindowsautopilotdeviceidentityGetParameter();
            return await this.SendAsync<IntuneEnrollmentWindowsautopilotdeviceidentityGetParameter, IntuneEnrollmentWindowsautopilotdeviceidentityGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-enrollment-windowsautopilotdeviceidentity-get?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneEnrollmentWindowsautopilotdeviceidentityGetResponse> IntuneEnrollmentWindowsautopilotdeviceidentityGetAsync(IntuneEnrollmentWindowsautopilotdeviceidentityGetParameter parameter)
        {
            return await this.SendAsync<IntuneEnrollmentWindowsautopilotdeviceidentityGetParameter, IntuneEnrollmentWindowsautopilotdeviceidentityGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-enrollment-windowsautopilotdeviceidentity-get?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneEnrollmentWindowsautopilotdeviceidentityGetResponse> IntuneEnrollmentWindowsautopilotdeviceidentityGetAsync(IntuneEnrollmentWindowsautopilotdeviceidentityGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<IntuneEnrollmentWindowsautopilotdeviceidentityGetParameter, IntuneEnrollmentWindowsautopilotdeviceidentityGetResponse>(parameter, cancellationToken);
        }
    }
}
