using OnlineTickets.Shared;
using System.Net.Http.Json;

namespace OnlineTickets.Client.Services.ActorServices
{
    public class ActorService : IActorService
    {
        private readonly HttpClient _httpClient;

        public List<Actor> Actors { get; set; } = new List<Actor>();

        public ActorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Actor>> GetActorsList()
        {
            Actors = await _httpClient.GetFromJsonAsync<List<Actor>>("/actor");
            if(Actors == null)
            {
                return new List<Actor>();
            }
            return Actors;
        }
    }
}
