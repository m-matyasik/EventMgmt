using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface IVenueRepository
{
    Task<Venue> GetVenueByIdAsync(int id);
    Task<IEnumerable<Venue>> GetAllVenuesAsync();
    Task AddVenueAsync(Venue venue);
    Task UpdateVenueAsync(Venue venue);
    Task DeleteVenueAsync(int id);
}