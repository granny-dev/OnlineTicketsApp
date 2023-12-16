using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.ActorServices
{
    public interface IActorService
    {
        List<Actor> Actors { get; set; }
        Task<List<Actor>> GetActorsList();
        Task<Actor> GetActorById(int id);
        Task AddActor(Actor actor);
        //Task UpdateActor(Actor actor);
        Task DeleteActor(int id);
    }
}
