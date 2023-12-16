using OnlineTickets.Shared;
using System.Net.Http.Json;

namespace OnlineTickets.Client.Services.MovieServices;

public class MovieService : IMovieService
{
    private readonly HttpClient _httpClient;

    public List<Movie>Movies { get; set; } = new List<Movie>();
    public MovieService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Movie>> GetMoviesList()
    {
        Movies = await _httpClient.GetFromJsonAsync<List<Movie>>("/movie");

        if(Movies == null)
        {
            return new List<Movie>();
        }
        return Movies;
    }
}
