﻿
namespace HigLabo.Net.Slack
{
    public partial class UsersSetPhotoParameter : IRestApiParameter
    {
        string IRestApiParameter.ApiPath { get; } = "users.setPhoto";
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string Crop_W { get; set; }
        public string Crop_X { get; set; }
        public string Crop_Y { get; set; }
        public string Image { get; set; }
    }
    public partial class UsersSetPhotoResponse : RestApiResponse
    {
    }
    public partial class SlackClient
    {
        public async Task<UsersSetPhotoResponse> UsersSetPhotoAsync()
        {
            var p = new UsersSetPhotoParameter();
            return await this.SendAsync<UsersSetPhotoParameter, UsersSetPhotoResponse>(p, CancellationToken.None);
        }
        public async Task<UsersSetPhotoResponse> UsersSetPhotoAsync(CancellationToken cancellationToken)
        {
            var p = new UsersSetPhotoParameter();
            return await this.SendAsync<UsersSetPhotoParameter, UsersSetPhotoResponse>(p, cancellationToken);
        }
        public async Task<UsersSetPhotoResponse> UsersSetPhotoAsync(UsersSetPhotoParameter parameter)
        {
            return await this.SendAsync<UsersSetPhotoParameter, UsersSetPhotoResponse>(parameter, CancellationToken.None);
        }
        public async Task<UsersSetPhotoResponse> UsersSetPhotoAsync(UsersSetPhotoParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<UsersSetPhotoParameter, UsersSetPhotoResponse>(parameter, cancellationToken);
        }
    }
}
