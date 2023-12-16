using Microsoft.EntityFrameworkCore;
using OnlineTickets.Server.Data;
using OnlineTickets.Shared;

namespace OnlineTickets.Server.Repositories.MovieRepositiries
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;

        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie>GetMovieByIdAsync(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.MovieId == id);
            if (movie == null)
            {
                return null;
            }
            return movie;
        }

        public async Task<Movie>AddMovieAsync(Movie movie)
        {
           _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> UpdateMovieAsync(Movie movie)
        {
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> DeleteMovieAsync(int id)
        {
            var movieToDelete = await _context.Movies.FirstOrDefaultAsync(m => m.MovieId == id);
            if(movieToDelete == null)
            {
                return null;
            }
            _context.Movies.Remove(movieToDelete);
            await _context.SaveChangesAsync();
            return movieToDelete;
        }      
    }
}
