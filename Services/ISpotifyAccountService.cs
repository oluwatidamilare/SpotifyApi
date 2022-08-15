namespace ConsumeSpotifyWebApi.Services
{
    public interface ISpotifyAccountService
    {
        Task<string> GetToken(string clientId, string clientSecret);
    }
}
