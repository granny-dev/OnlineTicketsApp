using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineTickets.Server.Repositories.ActorRepositories;
using OnlineTickets.Shared;

namespace OnlineTickets.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActorRepository _repository;

        public ActorController(IActorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Actor>>> GetAllActorsAsync()
        {           
            return Ok(await _repository.GetAllActorsAsync());          
        }

        [HttpGet("{actorId:int}")]
        public async Task<ActionResult<Actor>> GetActorByIdAsync(int actorId)
        {
            var actor = await _repository.GetActorByIdAsync(actorId);
           return Ok(actor);
        }

        [HttpPost]
        public async Task<ActionResult<Actor>> AddActorAsync(Actor actor)
        {
            return Ok(await _repository.AddActorAsync(actor));
        }

        [HttpPut("{actorId:int}")]
        public async Task<ActionResult<Actor>> UpdateActorAsync(Actor actor, int actorId)
        {
            actor.ActorId = actorId;
           await _repository.UpdateActorAsync(actor);
            return Ok(actor);
        }

        [HttpDelete("{actorId:int}")]
        public async Task<ActionResult<Actor>> DeleteActorAsync(int actorId)
        {
            await _repository.DeleteActorByIdAsync(actorId);
            return NoContent();
        }
    }
}
