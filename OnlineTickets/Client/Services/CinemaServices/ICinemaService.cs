using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.CinemaServices
{
    public interface ICinemaService
    {
        List<Cinema> Cinemas { get; set; }
        void GetCinemasList();
    }
}
