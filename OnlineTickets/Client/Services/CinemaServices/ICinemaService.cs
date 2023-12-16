using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.CinemaServices
{
    public interface ICinemaService
    {
        List<Cinema> Cinemas { get; set; }
        Task<List<Cinema>> GetCinemasList();
        Task<Cinema> GetCinemaById(int id);
        Task AddCinema(Cinema cinema);
        Task DeleteCinema(int id);
        //Task UpdateCinema(Cinema cinema);
    }
}
