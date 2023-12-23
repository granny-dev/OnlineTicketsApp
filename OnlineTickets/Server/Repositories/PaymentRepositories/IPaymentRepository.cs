using OnlineTickets.Shared;

namespace OnlineTickets.Server.Repositories.PaymentRepositories;

public interface IPaymentRepository
{
    Stripe.Checkout.Session CreateCheckoutSession(List<Movie> CartTickets);
}
