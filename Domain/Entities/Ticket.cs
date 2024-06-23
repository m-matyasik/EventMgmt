namespace Domain.Entities;

public class Ticket
{
    public int Id { get; set; }
    public string TicketNumber { get; set; } = string.Empty;
    public int EventId { get; set; }
    public Event Event { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}