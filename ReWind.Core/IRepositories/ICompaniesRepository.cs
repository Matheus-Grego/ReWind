using ReWind.Core.Entities;

namespace ReWind.Core.IRepositories;

public interface ICompaniesRepository
{
    Task<List<Companies>> GetAllCompanies();
    Task<Companies?> GetCompanyById(Guid CompanyId);
}