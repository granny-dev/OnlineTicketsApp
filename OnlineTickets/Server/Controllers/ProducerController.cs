using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineTickets.Server.Repositories.ProducerRepositories;
using OnlineTickets.Shared;

namespace OnlineTickets.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProducerController : ControllerBase
    {
        private readonly IProducerRepository _repository;

        public ProducerController(IProducerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Producer>>> GetAllProducersAsync()
        {
            
            return Ok(await _repository.GetAllProducersAsync());
        }

        [HttpGet("{producerId:int}")]
        public async Task<ActionResult<Producer>> GetProducerByIdAsync(int producerId)
        {
            var producer = await _repository.GetProducerByIdAsync(producerId);
            return Ok(producer);
        }

        [HttpPost]
        public async Task<ActionResult<Producer>> AddProducerAsync(Producer producer)
        {
            return Ok( await _repository.AddProducerAsync(producer));
        }

        [HttpPut("{producerId:int}")]
        public async Task<ActionResult<Producer>> UpdateProducerAsync(Producer producer, int producerId)
        {
            producer.ProducerId = producerId;
            await _repository.UpdateProducerAsync(producer);
            return Ok(producer);
        }

        [HttpDelete("{producerId:int}")]
        public async Task<ActionResult<Producer>> DeleteProducerAsync(int producerId)
        {
            await _repository.DeleteProducerAsync(producerId);
            return NoContent();
        }
    }
}
