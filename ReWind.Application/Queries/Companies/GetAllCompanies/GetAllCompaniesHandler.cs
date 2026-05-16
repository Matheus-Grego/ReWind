using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;
using ReWind.Core.IRepositories;

namespace ReWind.Application.Queries.Companies.GetAllCompanies;

public class GetAllCompaniesHandler : IRequestHandler<GetAllCompaniesQuery, Result<List<GetAllCompaniesDTO>>>
{
    private readonly ICompaniesRepository _repository;
    public GetAllCompaniesHandler(ICompaniesRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<List<GetAllCompaniesDTO>>> Handle(GetAllCompaniesQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetAllCompanies();
        var data = entity.Select(x => GetAllCompaniesDTO.FromEntity(x)).ToList();
        return Result<List<GetAllCompaniesDTO>>.Success(data);
    }
}