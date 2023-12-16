using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.ProducerServices
{
    public interface IProducerService
    {
        List<Producer> Producers { get; set; }
        Task<List<Producer>> GetProducersList();
    }
}
