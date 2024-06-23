using Domain.Entities;

namespace Domain.Interfaces.Services;

public interface IEventService
{
    Task<IEnumerable<Event>> GetAllEventsAsync();
    Task<Event> GetEventByIdAsync(int id);
    Task CreateEventAsync(Event ev);
    Task UpdateEventAsync(Event ev);
    Task DeleteEventAsync(int id);
}