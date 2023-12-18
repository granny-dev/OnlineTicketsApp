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

    public async Task<Movie> GetMovieById(int id)
    {
        var result = await _httpClient.GetFromJsonAsync<Movie>($"/movie/{id}");
        if(result == null)
        {
            return null;
        }
        return result;
    }

    public async Task AddMovie(Movie movie)
    {
        var result = await _httpClient.PostAsJsonAsync("/movie", movie);
    }

    public async Task DeleteMovie(int id)
    {
        var result = await _httpClient.DeleteAsync($"/movie/{id}");
    }

    public async Task UpdateMovie(Movie movie)
    {
        var result = await _httpClient.PutAsJsonAsync($"/movie/{movie.MovieId}", movie);
    }
}
