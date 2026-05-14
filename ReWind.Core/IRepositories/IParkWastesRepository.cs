using ReWind.Core.Entities;

namespace ReWind.Core.IRepositories;

public interface IParkWastesRepository
{
    Task<ParkWastes?> GetParkWasteById(Guid parkWasteId);
    Task UpdateParkWaste(List<ParkWastes> parkWastes);
    Task<List<ParkWastes>> GetParkWastesByParkId(Guid parkId);
}