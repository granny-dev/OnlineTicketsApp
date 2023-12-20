using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineTickets.Server.Repositories.StatsRepositories;

namespace OnlineTickets.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly IStatsRepository _statsRepository;

        public StatsController(IStatsRepository statsRepository)
        {
            _statsRepository = statsRepository;
        }


        [HttpGet]
        public async Task<ActionResult<int>> GetVisits()
        {
            return await _statsRepository.GetVisits();
        }

        [HttpPost]
        public async Task IncrementVisits()
        {
            await _statsRepository.IncrementVisits();
        }
    }
}
