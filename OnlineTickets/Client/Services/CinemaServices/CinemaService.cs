using OnlineTickets.Shared;
using System.Net.Http.Json;

namespace OnlineTickets.Client.Services.CinemaServices
{
    public class CinemaService : ICinemaService
    {
        private readonly HttpClient _httpClient;

        public List<Cinema> Cinemas { get; set; } = new List<Cinema>();

        public CinemaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Cinema>> GetCinemasList()
        {
            Cinemas = await _httpClient.GetFromJsonAsync<List<Cinema>>("/cinema");
            if(Cinemas == null)
            {
                return new List<Cinema>();
            }
            return Cinemas;  
        }
    }
}
