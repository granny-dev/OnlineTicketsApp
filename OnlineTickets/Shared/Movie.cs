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
    public DateTime SelectedDate { get; set; } = DateTime.Now;
    public decimal Price { get; set; }
    public int Qty {  get; set; }
    public int Reserved {  get; set; }
    public string Status { get; set; } = "Available";
    public string MovieCategory { get; set; } = string.Empty;
    public string MovieImageUrl { get; set; } = string.Empty;
    public int CinemaId { get; set; }
    public string CinemaName { get; set; } = string.Empty;
    public int ProducerId { get; set; }
    public string ProducerName { get; set;} = string.Empty;
   public string PlaceName {  get; set; } = string.Empty;
    public string CustomerEmail { get; set; } = string.Empty;
    public string PaymentStatus { get; set; } = string.Empty;
}
