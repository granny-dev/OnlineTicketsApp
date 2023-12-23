using OnlineTickets.Shared;
using Stripe;
using Stripe.Checkout;
using System.Net.Sockets;

namespace OnlineTickets.Server.Repositories.PaymentRepositories;

public class PaymentRepository : IPaymentRepository
{
    private readonly IConfiguration _configuration;

    public PaymentRepository(IConfiguration configuration)
    {
        StripeConfiguration.ApiKey = configuration["Stripe:SecretKey"];
        _configuration = configuration;
    }
    public Session CreateCheckoutSession(List<Movie> CartTickets)
    {
        var lineItems = new List<SessionLineItemOptions>();
        CartTickets.ForEach(CartTickets => lineItems.Add(new SessionLineItemOptions
        {
            PriceData = new SessionLineItemPriceDataOptions
            {
                UnitAmountDecimal = CartTickets.Price,
                Currency = "USD",
                ProductData = new SessionLineItemPriceDataProductDataOptions
                {
                    Name = CartTickets.MovieName,
                    Images = new List<string> { CartTickets.MovieImageUrl }
                }
            },
            Quantity = CartTickets.Qty,
        }));
        var options = new SessionCreateOptions
        {
            PaymentMethodTypes = new List<string> { "card", },

            LineItems = lineItems,
            Mode = "payment",
            SuccessUrl = "https://localhost:7225/payment/success?sessionId=" + "{CHECKOUT_SESSION_ID}",
            CancelUrl = "https://localhost:7225/cart",
        };

        var service = new SessionService();
        Session session = service.Create(options);
        session.CustomerEmail = CartTickets[0].CustomerEmail;

        return session;
    }
}
