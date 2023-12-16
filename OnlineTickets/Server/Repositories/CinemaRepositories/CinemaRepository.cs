using Microsoft.EntityFrameworkCore;
using OnlineTickets.Server.Data;
using OnlineTickets.Shared;

namespace OnlineTickets.Server.Repositories.CinemaRepositories
{
    public class CinemaRepository:ICinemaRepository
    {
        private readonly AppDbContext _context;

        public CinemaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cinema>> GetAllCinemasAsync()
        {
            return await _context.Cinemas.ToListAsync();
        }

        public async Task<Cinema>GetCinemaByIdAsync(int id)
        {
            var cinema =await _context.Cinemas.FirstOrDefaultAsync(c => c.CinemaId == id);
            if (cinema == null)
            {
                return null;
            }
            return cinema;
        }

        public async Task<Cinema> AddCinemaAsync(Cinema cinema)
        {
            
            _context.Cinemas.Add(cinema);
            await _context.SaveChangesAsync();
            return cinema;
        }



        public async Task<Cinema> UpdateCinemaAsync(Cinema cinema)
        {            
            _context.Cinemas.Update(cinema);
            await _context.SaveChangesAsync();
            return cinema;
        }

        public async Task<Cinema> DeleteCinemaAsync(int id)
        {
            var cinemaToDelete =await _context.Cinemas.FirstOrDefaultAsync(c => c.CinemaId == id);
            if(cinemaToDelete == null)
            {
                return null;
            }
            _context.Cinemas.Remove(cinemaToDelete);
            await _context.SaveChangesAsync();
            return cinemaToDelete;
        }
    }
}
