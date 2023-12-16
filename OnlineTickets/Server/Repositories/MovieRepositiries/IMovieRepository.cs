using OnlineTickets.Shared;

namespace OnlineTickets.Server.Repositories.MovieRepositiries
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
        Task<Movie> AddMovieAsync(Movie movie);
        Task<Movie> UpdateMovieAsync(Movie movie);
        Task<Movie> DeleteMovieAsync(int id);
    }
}
