using Microsoft.EntityFrameworkCore;
using OnlineTickets.Server.Data;
using OnlineTickets.Shared;

namespace OnlineTickets.Server.Repositories.ActorRepositories
{
    public class ActorRepository : IActorRepository
    {
        private readonly AppDbContext _context;

        public ActorRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Actor>> GetAllActorsAsync()
        {
            return await _context.Actors.ToListAsync();
        }

        public async Task<Actor> GetActorByIdAsync(int id)
        {
            var actor = await _context.Actors.FirstOrDefaultAsync(a => a.ActorId == id);
            if(actor == null)
            {
                return null;
            }
            return actor;
        }

        public async Task<Actor> AddActorAsync(Actor actor)
        {
            
            _context.Actors.Add(actor);
            await _context.SaveChangesAsync();
            return actor;
        }

        public async Task<Actor> DeleteActorByIdAsync(int id)
        {
           var actorToDelete = await _context.Actors.FirstOrDefaultAsync(a => a.ActorId == id);
            if(actorToDelete == null)
            {
                return null;
            }
            _context.Actors.Remove(actorToDelete);
            await _context.SaveChangesAsync();
            return actorToDelete;
        }
        public async Task<Actor> UpdateActorAsync(Actor actor)
        {
           
            _context.Actors.Update(actor);
            await _context.SaveChangesAsync();
            return actor;
        }


    }
}
