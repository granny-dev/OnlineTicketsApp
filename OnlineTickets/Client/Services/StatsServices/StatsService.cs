
using Blazored.LocalStorage;

namespace OnlineTickets.Client.Services.StatsServices;

public class StatsService : IStatsService
{
    private readonly HttpClient _httpClient;
    private readonly ILocalStorageService _service;

    public StatsService(HttpClient httpClient, ILocalStorageService service)
    {
        _httpClient = httpClient;
        _service = service;
    }
    public async Task GetVisits()
    {
        int visits = int.Parse(await _httpClient.GetStringAsync("stats"));
        Console.WriteLine(visits);
    }

    public async Task IncrementVisits()
    {
        DateTime? lastVisit = await _service.GetItemAsync<DateTime?>("lastVisit");
        if(lastVisit == null || ((DateTime)lastVisit).Date != DateTime.Now.Date)
        {
            await _service.SetItemAsync("lastVisit", DateTime.Now);
            await _httpClient.PostAsync("/stats", null);
        }
    }
}
