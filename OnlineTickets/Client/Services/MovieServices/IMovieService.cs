using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.MovieServices;

public interface IMovieService
{
    List<Movie> Movies { get; set; }
   Task<List<Movie>> GetMoviesList();
    Task<Movie> GetMovieById(int id);
    Task AddMovie(Movie movie);
    Task DeleteMovie(int id);
    //Task UpdateMovie(Movie movie);
    
}
