using Blazored.LocalStorage;
using Blazored.Toast.Services;
using OnlineTickets.Client.Services.MovieServices;
using OnlineTickets.Shared;
using System.Net.Http.Json;

namespace OnlineTickets.Client.Services.CartServices
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly IToastService _toastService;
        private readonly IMovieService _movieService;
        private readonly HttpClient _httpClient;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorageService, IToastService toastService, IMovieService movieService, HttpClient httpClient)
        {
            _localStorageService = localStorageService;
            _toastService = toastService;
            _movieService = movieService;
            _httpClient = httpClient;
        }

        public async Task AddToCart(Movie movie)
        {
            var cart = await _localStorageService.GetItemAsync<List<Movie>>("cart");
            if(cart == null)
            {
                cart = new List<Movie>();
            }

            if(movie.Status == "Available")
            {
                cart.Add(movie);
                movie.Reserved += movie.Qty;
                await _movieService.UpdateReserved(movie.MovieId, movie.Reserved);
                await _localStorageService.SetItemAsync("cart", cart);
                _toastService.ShowSuccess($"{movie.MovieName} added successfully!");
            }


            OnChange?.Invoke();
        }

        public async Task EditTicket(Movie movie)
        {
            var cart = await _localStorageService.GetItemAsync<List<Movie>>("cart");
            if (cart == null)
            {
                cart = new List<Movie>();
            }

            var ticketToUpdate = cart.FirstOrDefault(t => t.MovieId == movie.MovieId);
            if(ticketToUpdate == null)
            {
                return;
            }
            cart.Remove(ticketToUpdate);
            cart.Add(movie);
            await _localStorageService.SetItemAsync("cart", cart);
            _toastService.ShowSuccess($"{movie.MovieName} edited successfully!");
        }

        public async Task<List<Movie>> GetAllTickets()
        {
            var result = new List<Movie>();
            var cart = await _localStorageService.GetItemAsync<List<Movie>>("cart");
            if(cart == null)
            {
                return result;
            }

            foreach(var movie in cart)
            {
                result.Add(movie);
            }
            return result;
        }

        public async Task DeleteFromCart(Movie movie)
        {
            var cart = await _localStorageService.GetItemAsync<List<Movie>>("cart");
            if (cart == null)
            {
                return;
            }

            var ticketToDelete = cart.FirstOrDefault(t => t.MovieId == movie.MovieId &&  t.SelectedDate == movie.SelectedDate && t.PlaceName == movie.PlaceName);
            if (ticketToDelete == null)
            {
                return;
            }
            cart.Remove(ticketToDelete);
            ticketToDelete.Reserved -= ticketToDelete.Qty;
            await _movieService.UpdateReserved(ticketToDelete.MovieId, ticketToDelete.Reserved);
            await _localStorageService.SetItemAsync("cart", cart);
            _toastService.ShowSuccess($"{movie.MovieName} deleted successfully!");

            OnChange?.Invoke();
        }

        public async Task<string> Checkout()
        {
            var tickets = await GetAllTickets();

            var result = await _httpClient.PostAsJsonAsync("/payment/checkout", tickets);
            var url = await result.Content.ReadAsStringAsync();
            return url;
        }

        public async Task SendEmail(string customerEmail, string subject, string body)
        {
            var email = new Email
            {
                Address = customerEmail,
                Subject = subject,
                Body = body
            };

            await _httpClient.PostAsJsonAsync($"/email", email);
        }

        public async Task EmptyCart()
        {
            await _localStorageService.RemoveItemAsync("cart");
            OnChange.Invoke();
        }
    }
}
