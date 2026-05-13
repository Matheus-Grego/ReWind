using Microsoft.EntityFrameworkCore;
using ReWind.Core.Entities;
using ReWind.Core.IRepositories;
using ReWind.Infrastructure.Persistance;

namespace ReWind.Infrastructure.Repositories;

public class ParksRepository : IParksRepository 
{
    private readonly ReWindDBContext _dbContext;

    public ParksRepository(ReWindDBContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<Parks>> GetAllParks()
    {
        return await _dbContext.Parks.AsNoTracking().ToListAsync();
    }

    public async Task<Parks?> GetParkById(Guid parkId)
    {
        return await _dbContext.Parks.Include(x => x.Wastes)
            .ThenInclude(x => x.Waste)
            .Include(X => X.Owners)
            .AsSplitQuery()
            .SingleOrDefaultAsync(x => x.Id == parkId);
    }

    public async Task RegisterPark(Parks park)
    {
        await _dbContext.Parks.AddAsync(park);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<ParkWastes>> GetParkWastes(Guid parkId)
    {
        return await _dbContext.ParkWastes.Where(x => x.ParkId == parkId).ToListAsync();
    }
    
}