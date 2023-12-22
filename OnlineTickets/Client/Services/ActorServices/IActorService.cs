using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.ActorServices
{
    public interface IActorService
    {
       
        Task<List<Actor>> GetActorsList();
        Task<Actor> GetActorById(int id);
        Task AddActor(Actor actor);
        Task UpdateActor(Actor actor);
        Task DeleteActor(int id);
    }
}
