using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.MovieServices;

public interface IMovieService
{
    List<Movie> Movies { get; set; }
   void GetMoviesList();
    
}
