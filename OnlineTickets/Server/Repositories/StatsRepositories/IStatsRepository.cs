namespace OnlineTickets.Server.Repositories.StatsRepositories;

public interface IStatsRepository
{
    Task<int> GetVisits();
    Task IncrementVisits();
}
