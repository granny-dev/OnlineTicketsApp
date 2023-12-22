using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.ProducerServices
{
    public interface IProducerService
    {
        Task<List<Producer>> GetProducersList();
        Task<Producer> GetProducerById(int id);
        Task AddProducer(Producer producer);
        Task DeleteProducer(int id);
        Task UpdateProducer(Producer producer);

    }
}
