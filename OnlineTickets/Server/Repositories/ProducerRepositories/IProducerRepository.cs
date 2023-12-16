using OnlineTickets.Shared;

namespace OnlineTickets.Server.Repositories.ProducerRepositories
{
    public interface IProducerRepository
    {
        Task<List<Producer>> GetAllProducersAsync();

        Task <Producer> GetProducerByIdAsync(int producerId);
        Task<Producer> AddProducerAsync(Producer producer);
        Task<Producer> DeleteProducerAsync(int producerId);
        Task<Producer> UpdateProducerAsync(Producer producer);
    }
}
