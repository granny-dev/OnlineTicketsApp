using OnlineTickets.Shared;
using System.Net.Http.Json;

namespace OnlineTickets.Client.Services.ProducerServices
{
    public class ProducerService : IProducerService
    {
        private readonly HttpClient _httpClient;

        public List<Producer> Producers { get; set; } = new List<Producer>();
        public ProducerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Producer>> GetProducersList()
        {
            Producers = await _httpClient.GetFromJsonAsync<List<Producer>>("/producer");
            if( Producers == null )
            {
                return new List<Producer>();
            }
            return Producers;
        }
    }
}
