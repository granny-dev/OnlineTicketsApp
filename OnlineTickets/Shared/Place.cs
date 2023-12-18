using System.Text.Json.Serialization;

namespace OnlineTickets.Shared;

public class Place
{
    public int PlaceId { get; set; }
    public string PlaceName { get; set; } = string.Empty;

    [JsonIgnore]
    public List<Movie> Movies { get; set; } = new List<Movie>();    
}
