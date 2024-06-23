namespace Domain.Entities;

public class Venue
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public ICollection<Event> Events { get; set; } = [];
}