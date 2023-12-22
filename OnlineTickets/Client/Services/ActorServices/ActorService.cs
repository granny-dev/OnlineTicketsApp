using OnlineTickets.Shared;
using System.Net.Http.Json;

namespace OnlineTickets.Client.Services.ActorServices
{
    public class ActorService : IActorService
    {
        private readonly HttpClient _httpClient;



        public ActorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Actor>> GetActorsList()
        {
            var actors = await _httpClient.GetFromJsonAsync<List<Actor>>("/actor");
            if(actors == null)
            {
                return new List<Actor>();
            }
            return actors;
        }

        public async Task<Actor> GetActorById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Actor>($"/actor/{id}");
            if(result == null)
            {
                return null;
            }
            return result;
        }

        public async Task UpdateActor(Actor actor)
        {
            var result = await _httpClient.PutAsJsonAsync($"/actor/{actor.ActorId}", actor);
        }

        public async Task DeleteActor(int id)
        {
            var result = await _httpClient.DeleteAsync($"/actor/{id}");
        }

        public async Task AddActor(Actor actor)
        {
            var result = await _httpClient.PostAsJsonAsync("/actor", actor);
        }
    }
}
