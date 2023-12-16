using OnlineTickets.Shared;

namespace OnlineTickets.Server.Repositories.ActorRepositories
{
    public interface IActorRepository
    {
        Task<List<Actor>> GetAllActorsAsync();
        Task<Actor> GetActorByIdAsync(int id);
        Task<Actor> AddActorAsync(Actor actor);
        Task<Actor> DeleteActorByIdAsync(int id);
        Task<Actor> UpdateActorAsync(Actor actor);
    }
}
