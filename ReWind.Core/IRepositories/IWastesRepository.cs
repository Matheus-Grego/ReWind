using ReWind.Core.Entities;

namespace ReWind.Core.IRepositories;

public interface IWastesRepository
{
    Task<List<Wastes>> GetAllWastes();
    Task InsertWaste(Wastes waste);
}