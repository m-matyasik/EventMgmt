using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface IEventRepository
{
    Task<Event> GetEventByIdAsync(int id);
    Task<IEnumerable<Event>> GetAllEventsAsync();
    Task AddEventAsync(Event ev);
    Task UpdateEventAsync(Event ev);
    Task DeleteEventAsync(int id);
}