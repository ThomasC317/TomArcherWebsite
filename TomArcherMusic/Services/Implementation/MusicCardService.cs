using Microsoft.AspNetCore.Components;
using TomArcherMusic.Services.Interfaces;
using TomArcherMusicContracts;

namespace TomArcherMusic.Services.Implementation
{
    public class MusicCardService : IMusicCardService
    {
        HttpClient _httpClient;
        public MusicCardService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        public async Task<List<MusicCardDto>> GetAll()
        {
            var list = await _httpClient.GetFromJsonAsync<List<MusicCardDto>>("GetMusicCards");
            if (list.Any())
                return list;
            else
                return null;
        }
    }
}
