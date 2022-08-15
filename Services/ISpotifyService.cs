using ConsumeSpotifyWebApi.Models;

namespace ConsumeSpotifyWebApi.Services
{
    public interface ISpotifyService
    {
        Task<IEnumerable<Release>> GetNewReleases(string countryCode, int limit, string accessToken);
    }
}
