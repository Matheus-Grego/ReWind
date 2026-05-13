using Microsoft.EntityFrameworkCore;
using ReWind.Core.Entities;
using ReWind.Core.IRepositories;
using ReWind.Infrastructure.Persistance;

namespace ReWind.Infrastructure.Repositories;

public class WastesRepository : IWastesRepository
{
    private readonly ReWindDBContext _dbContext;

    public WastesRepository(ReWindDBContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<Wastes>> GetAllWastes()
    {
        return await _dbContext.Wastes.AsNoTracking().ToListAsync();
    }

    public async Task InsertWaste(Wastes waste)
    {
        await _dbContext.Wastes.AddAsync(waste);
        await _dbContext.SaveChangesAsync();
    }
}