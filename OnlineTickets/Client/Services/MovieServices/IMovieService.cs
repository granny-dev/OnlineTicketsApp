using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.MovieServices;

public interface IMovieService
{
   Task<List<Movie>> GetMoviesList();
    Task<Movie> GetMovieById(int id);
    Task AddMovie(Movie movie);
    Task DeleteMovie(int id);
    Task UpdateMovie(Movie movie);
    Task UpdateReserved(int movieId, int reserved);
    Task<List<Movie>> SearchMovie(string searchMovie);

}
