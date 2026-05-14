using Microsoft.EntityFrameworkCore;
using ReWind.Core.Entities;
using ReWind.Core.IRepositories;
using ReWind.Infrastructure.Persistance;

namespace ReWind.Infrastructure.Repositories;

public class ParkWastesRepository : IParkWastesRepository
{
    private readonly ReWindDBContext _dbContext;

    public ParkWastesRepository(ReWindDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ParkWastes?> GetParkWasteById(Guid parkWasteId)
    {
        return await _dbContext.ParkWastes.Include(x => x.Waste).AsSplitQuery().SingleOrDefaultAsync(x => x.Id == parkWasteId);
    }
    
    public async Task UpdateParkWaste(List<ParkWastes> parkWastes)
    {
        _dbContext.ParkWastes.UpdateRange(parkWastes);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task<List<ParkWastes>> GetParkWastesByParkId(Guid parkId)
    {
        return await _dbContext.ParkWastes.Where(x => x.ParkId == parkId).Include(x => x.Waste).AsSplitQuery().ToListAsync();
    }
}