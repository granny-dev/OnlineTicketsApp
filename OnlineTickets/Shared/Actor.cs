using System.ComponentModel.DataAnnotations;

namespace OnlineTickets.Shared;

public class Actor
{
    [Key]
    public int ActorId { get; set; }
    public string ActorProfilePictureURL { get; set; } = string.Empty;
    public string ActorName { get; set; } = string.Empty;
    public string ActorBiography { get; set; } = string.Empty;
    public int MovieId { get; set; }
}
