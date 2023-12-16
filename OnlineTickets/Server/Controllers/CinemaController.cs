using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineTickets.Server.Repositories.CinemaRepositories;
using OnlineTickets.Shared;

namespace OnlineTickets.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly ICinemaRepository _repository;

        public CinemaController(ICinemaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cinema>>> GetAllCinemasAsync()
        {           
            return Ok(await _repository.GetAllCinemasAsync());           
        }

        [HttpGet("{cinemaId:int}")]
        public async Task<ActionResult<Cinema>> GetCinemaByIdAsync(int cinemaId)
        {
            var cinema = await _repository.GetCinemaByIdAsync(cinemaId);
            return Ok(cinema);
        }

        [HttpPost]
        public async Task<ActionResult<Cinema>> AddCinemaAsync(Cinema cinema)
        {
            return Ok(await _repository.AddCinemaAsync(cinema));
        }

        [HttpPut("{cinemaId:int}")]
        public async Task<ActionResult<Cinema>> UpdateCinemaAsync(Cinema cinema, int cinemaId)
        {
           cinema.CinemaId = cinemaId;
            await _repository.UpdateCinemaAsync(cinema);
            return Ok(cinema);

        }

        [HttpDelete("{cinemaId:int}")]
        public async Task<ActionResult<Cinema>> DeleteCinemaAsync(int cinemaId)
        {
            await _repository.DeleteCinemaAsync(cinemaId);
            return NoContent();
        }
    }
}
