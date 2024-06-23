namespace Domain.Entities;

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Description { get; set; } = string.Empty;
    public int OrganizerId { get; set; }
    public User Organizer { get; set; }
}