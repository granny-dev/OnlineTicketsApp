namespace OnlineTickets.Client.Services.StatsServices
{
    public interface IStatsService
    {
        Task GetVisits();
        Task IncrementVisits();
    }
}
