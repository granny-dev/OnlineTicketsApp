
using Microsoft.EntityFrameworkCore;
using OnlineTickets.Server.Data;
using OnlineTickets.Shared;

namespace OnlineTickets.Server.Repositories.StatsRepositories;

public class StatsRepository : IStatsRepository
{
    private readonly AppDbContext _context;

    public StatsRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<int> GetVisits()
    {
        var stats = await _context.Stats.FirstOrDefaultAsync();
        if (stats == null)
        {
            return 0;
        }
        return stats.Visits;
    }

    public async Task IncrementVisits()
    {
        var stats = await _context.Stats.FirstOrDefaultAsync();
        if (stats == null)
        {
            _context.Stats.Add(new Stats { Visits = 1, LastVisit = DateTime.Now });
        }
        else
        {
            stats.Visits++;
            stats.LastVisit = DateTime.Now;
        }
        await _context.SaveChangesAsync();
    }
}
