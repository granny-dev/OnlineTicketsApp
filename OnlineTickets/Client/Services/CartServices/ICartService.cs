﻿using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.CartServices
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(Movie movie);
        Task<List<Movie>> GetAllTickets();

        Task DeleteFromCart(Movie movie);
        Task EditTicket(Movie movie);
        Task<string> Checkout();
        Task SendEmail(string customerEmail, string subject, string body);
        Task EmptyCart();
    }
}
