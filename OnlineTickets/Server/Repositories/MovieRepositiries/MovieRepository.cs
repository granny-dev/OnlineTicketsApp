using Microsoft.EntityFrameworkCore;
using OnlineTickets.Client.Pages;
using OnlineTickets.Server.Data;
using OnlineTickets.Server.Repositories.CinemaRepositories;
using OnlineTickets.Shared;

namespace OnlineTickets.Server.Repositories.MovieRepositiries
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;
        private readonly ICinemaRepository _cinemaRepository;

        public MovieRepository(AppDbContext context, ICinemaRepository cinemaRepository)
        {
            _context = context;
            _cinemaRepository = cinemaRepository;
        }
        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            var movies = await _context.Movies.ToListAsync();
            if(movies == null)
            {
                return new List<Movie>();
            }
            foreach(var movie in movies)
            {
                movie.Status = await GetStatusAsync(movie);
            }
            return movies;
        }

        public async Task<Movie>GetMovieByIdAsync(int id)
        {
            var movie = await _context.Movies.Include(m => m.Places).FirstOrDefaultAsync(m => m.MovieId == id);
            if (movie == null)
            {
                return null;
            }
            movie.Status = await GetStatusAsync(movie);
            return movie;
        }

        public async Task<Movie>AddMovieAsync(Movie movie)
        {
            movie.Status = await GetStatusAsync(movie);
           _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> UpdateMovieAsync(Movie movie)
        {
            movie.Status = await GetStatusAsync(movie);
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

        public async Task<string> GetStatusAsync(Movie movie)
        {
            var cinema = await _cinemaRepository.GetCinemaByIdAsync(movie.CinemaId);
            var range = _context.Movies.Where(m => m.SelectedDate <= movie.EndDate &&  m.SelectedDate >= movie.StartDate);
            var availableTickets = cinema.Capacity - movie.Reserved;

            foreach (var date in range)
            {
                if (availableTickets > 0)
                {
                    movie.Status = "Available";
                }
                else
                {
                    movie.Status = "SoldOut";
                }
            }
            return movie.Status;
        }
    }
}
