using Microsoft.EntityFrameworkCore;
using OnlineTickets.Server.Data;
using OnlineTickets.Shared;

namespace OnlineTickets.Server.Repositories.ProducerRepositories
{
    public class ProducerRepository : IProducerRepository
    {
        private readonly AppDbContext _context;

        public ProducerRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Producer>> GetAllProducersAsync()
        {
            return await  _context.Producers.ToListAsync();
        }

        public async Task<Producer>GetProducerByIdAsync(int producerId)
        {
            var producer = await _context.Producers.FirstOrDefaultAsync(p => p.ProducerId == producerId);
            if(producer == null)
            {
                return null;
            }
            return producer;
        }

        public async Task<Producer>AddProducerAsync(Producer producer)
        {
            _context.Producers.Add(producer);
            await _context.SaveChangesAsync();
            return producer;
        }

        public async Task<Producer>DeleteProducerAsync(int producerId)
        {
            var producerToDelete  = await _context.Producers.FirstOrDefaultAsync(p => p.ProducerId == producerId);
            if(producerToDelete == null)
            {
                return null;
            }
            _context.Producers.Remove(producerToDelete);
            await _context.SaveChangesAsync();
            return producerToDelete;
        }



        public async Task<Producer> UpdateProducerAsync(Producer producer)
        {
            _context.Producers.Update(producer);
            await _context.SaveChangesAsync();
            return producer;
        }
    }
}
