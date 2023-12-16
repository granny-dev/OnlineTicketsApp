using OnlineTickets.Shared;

namespace OnlineTickets.Server.Repositories.CinemaRepositories
{
    public interface ICinemaRepository
    {
        Task<List<Cinema>> GetAllCinemasAsync();
        Task<Cinema> GetCinemaByIdAsync(int id);
        Task<Cinema> AddCinemaAsync(Cinema cinema);
        Task<Cinema> UpdateCinemaAsync(Cinema cinema);
        Task<Cinema> DeleteCinemaAsync(int id);
    }
}
