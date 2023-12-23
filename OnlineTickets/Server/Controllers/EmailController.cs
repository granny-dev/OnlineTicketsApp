using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineTickets.Server.Repositories.EmailRepositories;
using OnlineTickets.Shared;

namespace OnlineTickets.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailRepository _repository;

        public EmailController(IEmailRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Send(Email email)
        {
            _repository.Send(email.Address, email.Subject, email.Body);
            return Ok();
        }
    }
}
