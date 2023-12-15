using System.ComponentModel.DataAnnotations;

namespace OnlineTickets.Shared;

public class Producer
{
    [Key]
    public int ProducerId { get; set; }
    public string ProducerProfilePictureURL { get; set; } = string.Empty;
    public string ProducerName { get; set; } = string.Empty;
    public string ProducerBiography { get; set; } = string.Empty;
    public List<Movie> Movies { get; set; } = new List<Movie>();
}
