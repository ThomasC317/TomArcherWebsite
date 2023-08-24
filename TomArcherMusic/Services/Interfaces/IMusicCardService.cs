using TomArcherMusicContracts;

namespace TomArcherMusic.Services.Interfaces
{
    public interface IMusicCardService
    {
        public Task<List<MusicCardDto>> GetAll();
    }
}
