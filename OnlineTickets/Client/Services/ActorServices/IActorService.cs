using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.ActorServices
{
    public interface IActorService
    {
        List<Actor> Actors { get; set; }
        Task<List<Actor>> GetActorsList();
    }
}
