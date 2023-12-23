using Microsoft.AspNetCore.JsonPatch;
using Newtonsoft.Json;
using OnlineTickets.Shared;
using System.Net.Http.Headers;
using System;
using System.Net.Http.Json;
using System.Text;

namespace OnlineTickets.Client.Services.MovieServices;

public class MovieService : IMovieService
{
    private readonly HttpClient _httpClient;

    public MovieService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Movie>> GetMoviesList()
    {
        var movies = await _httpClient.GetFromJsonAsync<List<Movie>>("/movie");

        if(movies == null)
        {
            return new List<Movie>();
        }
        return movies;
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
        var movieToUpdate = new Movie();
        
           movieToUpdate. MovieId = movie.MovieId;
            movieToUpdate.MovieName = movie.MovieName;
            movieToUpdate.MovieDescription = movie.MovieDescription;
            movieToUpdate.MovieCategory = movie.MovieCategory;
            movieToUpdate.MovieImageUrl = movie.MovieImageUrl;
            movieToUpdate.SelectedDate = movie.SelectedDate;
            movieToUpdate.StartDate = movie.StartDate;
            movieToUpdate.EndDate = movie.EndDate;
            movieToUpdate.Reserved = movie.Reserved;
            movieToUpdate.Status = movie.Status;
            movieToUpdate.CinemaId = movie.CinemaId;
            movieToUpdate.CinemaName = movie.CinemaName;
            movieToUpdate.ProducerId = movie.ProducerId;
            movieToUpdate.ProducerName = movie.ProducerName;
            if(movie.PlaceName == "FirstRow")
            {
                movieToUpdate.Price = movie.Price/2;
            }

        
        var result = await _httpClient.PutAsJsonAsync($"/movie/{movie.MovieId}", movieToUpdate);
    }

    public async Task UpdateReserved (int movieId, int reserved)
    {
        var result = await _httpClient.PatchAsJsonAsync<Movie>($"/movie/{movieId}", new Movie {Reserved = reserved});
    }

    public async Task<List<Movie>> SearchMovie(string searchMovie)
    {
        var result = await _httpClient.GetFromJsonAsync<List<Movie>>($"/movie/Search/{searchMovie}");
        if(result == null)
        {
            return new List<Movie>();
        }
        return result;
    }
}