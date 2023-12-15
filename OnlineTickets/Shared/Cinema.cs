using System.ComponentModel.DataAnnotations;

namespace OnlineTickets.Shared;

public class Cinema
{
    [Key]
    public int CinemaId { get; set; }
    public string CinemaLogo { get; set; } = string.Empty;
    public string CinemaName { get; set; } = string.Empty;
    public string CinemaDescription { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public List<Movie> Movies { get; set; } = new List<Movie>();
}
