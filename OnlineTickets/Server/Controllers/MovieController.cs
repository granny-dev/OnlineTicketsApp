using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using OnlineTickets.Server.Repositories.MovieRepositiries;
using OnlineTickets.Shared;

namespace OnlineTickets.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _repository;

        public MovieController(IMovieRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Movie>>> GetAllMoviesAsync()
        {
            return Ok(await _repository.GetAllMoviesAsync());
        }


        [HttpGet("{movieId:int}")]
        public async Task<ActionResult<Movie>> GetMovieByIdAsync(int movieId)
        {
            var movie = await _repository.GetMovieByIdAsync(movieId);
            return Ok(movie);
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> AddMovieAsync(Movie movie)
        {
            return Ok(await _repository.AddMovieAsync(movie));
        }

        [HttpPut("{movieId:int}")]
        public async Task<ActionResult<Movie>> UpdateMovieASync(Movie movie)
        {
            await _repository.UpdateMovieAsync(movie);
            return Ok(movie);
        }

        [HttpPatch("{movieId:int}")]
        public async Task<ActionResult> UpdateReservedAsync(int movieId, int reserved)
        {            
            await _repository.UpdateReservedAsync(movieId, reserved);
            return Ok(movieId);
        }
    }

   
}
