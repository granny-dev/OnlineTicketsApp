using OnlineTickets.Shared;
using System.Net.Http.Json;

namespace OnlineTickets.Client.Services.CinemaServices
{
    public class CinemaService : ICinemaService
    {
        private readonly HttpClient _httpClient;


        public CinemaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Cinema>> GetCinemasList()
        {
            var cinemas = await _httpClient.GetFromJsonAsync<List<Cinema>>("/cinema");
            if(cinemas == null)
            {
                return new List<Cinema>();
            }
            return cinemas;  
        }

        public async Task<Cinema> GetCinemaById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Cinema>($"/cinema/{id}");
            if(result == null)
            {
                return null;
            }
            return result;
        }

        public async Task AddCinema(Cinema cinema)
        {
            var result = await _httpClient.PostAsJsonAsync("/cinema", cinema);
        }

        public async Task DeleteCinema(int id)
        {
            var result = await _httpClient.DeleteAsync($"/cinema/{id}");
        }

        public async Task UpdateCinema(Cinema cinema)
        {
            var result = await _httpClient.PutAsJsonAsync($"/cinema/{cinema.CinemaId}", cinema);
        }
    }
}
