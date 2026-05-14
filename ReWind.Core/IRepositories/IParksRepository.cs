using ReWind.Core.Entities;

namespace ReWind.Core.IRepositories;

public interface IParksRepository
{
    Task<List<Parks>> GetAllParks();
    Task<Parks?> GetParkById(Guid parkId);
}