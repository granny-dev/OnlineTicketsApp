using Blazored.LocalStorage;
using Blazored.Toast.Services;
using OnlineTickets.Client.Services.MovieServices;
using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.CartServices
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly IToastService _toastService;
        private readonly IMovieService _movieService;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorageService, IToastService toastService, IMovieService movieService)
        {
            _localStorageService = localStorageService;
            _toastService = toastService;
            _movieService = movieService;
        }

        public async Task AddToCart(Movie movie)
        {
            var cart = await _localStorageService.GetItemAsync<List<Movie>>("cart");
            if(cart == null)
            {
                cart = new List<Movie>();
            }
            
            var isAvailable =  _movieService.Movies.Any(m =>(m.SelectedDate <= movie.EndDate && m.SelectedDate >= movie.StartDate) && (m.Status == "Available"));
            if(!isAvailable)
            {
                return;
            }
            cart.Add(movie);
            movie.Reserved++;
            await _localStorageService.SetItemAsync("cart", cart);
            _toastService.ShowSuccess($"{movie.MovieName} added successfully!");

            OnChange?.Invoke();
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

            var ticketToDelete = cart.FirstOrDefault(t => t.MovieId == movie.MovieId && t.PlaceId == movie.PlaceId && t.SelectedDate == movie.SelectedDate);
            if (ticketToDelete == null)
            {
                return;
            }
            cart.Remove(ticketToDelete);
            movie.Reserved--;
            await _localStorageService.SetItemAsync("cart", cart);
            _toastService.ShowSuccess($"{movie.MovieName} deleted successfully!");

            OnChange?.Invoke();
        }
    }
}
