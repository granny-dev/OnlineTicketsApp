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

        public async Task<Producer> GetProducerById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Producer>($"/producer/{id}");
            if( result == null)
            {
                return null;
            }
            return result;
        }

        public async Task AddProducer(Producer producer)
        {
            var result = await _httpClient.PostAsJsonAsync("/producer", producer);
        }

        public async Task DeleteProducer(int id)
        {
            var result = await _httpClient.DeleteAsync($"/producer/{id}");
        }

        //public async Task UpdateProducer(Producer producer)
        //{
        //    var result = await _httpClient.PutAsJsonAsync($"/producer/{producer.ProducerId}", producer);
        //}
    }
}
