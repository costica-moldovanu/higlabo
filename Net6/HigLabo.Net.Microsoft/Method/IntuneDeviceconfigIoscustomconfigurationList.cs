﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class IntuneDeviceconfigIoscustomconfigurationListParameter : IRestApiParameter, IQueryParameterProperty
    {
        public enum Field
        {
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
    public partial class IntuneDeviceconfigIoscustomconfigurationListResponse : RestApiResponse
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/resources/intune-deviceconfig-ioscustomconfiguration?view=graph-rest-1.0
        /// </summary>
        public partial class IosCustomConfiguration
        {
            public string? Id { get; set; }
            public DateTimeOffset? LastModifiedDateTime { get; set; }
            public DateTimeOffset? CreatedDateTime { get; set; }
            public string? Description { get; set; }
            public string? DisplayName { get; set; }
            public Int32? Version { get; set; }
            public string? PayloadName { get; set; }
            public string? PayloadFileName { get; set; }
            public string? Payload { get; set; }
        }

        public IosCustomConfiguration[] Value { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-deviceconfig-ioscustomconfiguration-list?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneDeviceconfigIoscustomconfigurationListResponse> IntuneDeviceconfigIoscustomconfigurationListAsync()
        {
            var p = new IntuneDeviceconfigIoscustomconfigurationListParameter();
            return await this.SendAsync<IntuneDeviceconfigIoscustomconfigurationListParameter, IntuneDeviceconfigIoscustomconfigurationListResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-deviceconfig-ioscustomconfiguration-list?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneDeviceconfigIoscustomconfigurationListResponse> IntuneDeviceconfigIoscustomconfigurationListAsync(CancellationToken cancellationToken)
        {
            var p = new IntuneDeviceconfigIoscustomconfigurationListParameter();
            return await this.SendAsync<IntuneDeviceconfigIoscustomconfigurationListParameter, IntuneDeviceconfigIoscustomconfigurationListResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-deviceconfig-ioscustomconfiguration-list?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneDeviceconfigIoscustomconfigurationListResponse> IntuneDeviceconfigIoscustomconfigurationListAsync(IntuneDeviceconfigIoscustomconfigurationListParameter parameter)
        {
            return await this.SendAsync<IntuneDeviceconfigIoscustomconfigurationListParameter, IntuneDeviceconfigIoscustomconfigurationListResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/intune-deviceconfig-ioscustomconfiguration-list?view=graph-rest-1.0
        /// </summary>
        public async Task<IntuneDeviceconfigIoscustomconfigurationListResponse> IntuneDeviceconfigIoscustomconfigurationListAsync(IntuneDeviceconfigIoscustomconfigurationListParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<IntuneDeviceconfigIoscustomconfigurationListParameter, IntuneDeviceconfigIoscustomconfigurationListResponse>(parameter, cancellationToken);
        }
    }
}
