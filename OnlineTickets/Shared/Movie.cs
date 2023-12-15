using System.ComponentModel.DataAnnotations;

namespace OnlineTickets.Shared;

public class Movie
{
    [Key]
    public int MovieId { get; set; }
    public string MovieName { get; set; } = string.Empty;
    public string MovieDescription { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Price { get; set; }
    public string MovieCategory { get; set; } = string.Empty;
    public string MovieImageUrl { get; set; } = string.Empty;
    public List<Actor>?Actors { get; set; }
    public int CinemaId { get; set; }
    public string CinemaName { get; set; } = string.Empty;
    public int ProducerId { get; set; }
    public string ProducerName { get; set;} = string.Empty;
}
