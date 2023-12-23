using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineTickets.Server.Repositories.PaymentRepositories;
using OnlineTickets.Shared;
using Stripe.Checkout;

namespace OnlineTickets.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _repository;

        public PaymentController(IPaymentRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("checkout")]
        public ActionResult CreateCheckoutSession([FromBody] List<Movie> CartTickets)
        {
            var session = _repository.CreateCheckoutSession(CartTickets);
            return Ok(session.Url);
        }

        [HttpGet("success")]
        public ActionResult PaymentSuccess(string sessionId)
        {
            var sessionService = new SessionService();
            var session = sessionService.Get(sessionId);

            var customerEmail = session.CustomerDetails.Email;
            var paymentStatus = session.PaymentStatus;

            return Redirect($"/payment-succeeded");
        }
    }
}
