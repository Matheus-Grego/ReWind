using Microsoft.EntityFrameworkCore;
using ReWind.Core.Entities;
using ReWind.Core.IRepositories;
using ReWind.Infrastructure.Persistance;

namespace ReWind.Infrastructure.Repositories;

public class CompaniesRepository : ICompaniesRepository
{
    private readonly ReWindDBContext _dbContext;

    public CompaniesRepository(ReWindDBContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<Companies>> GetAllCompanies()
    {
        return await _dbContext.Companies.AsNoTracking().ToListAsync();
    }

    public async Task<Companies?> GetCompanyById(Guid CompanyId)
    {
        return await _dbContext.Companies.SingleOrDefaultAsync(x => x.Id == CompanyId);
    }
}