using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;
using ReWind.Core.IRepositories;

namespace ReWind.Application.Queries.Companies.GetCompanyById;

public class GetCompanyByIdHandler : IRequestHandler<GetCompanyByIdQuery, Result<GetCompanyByIdDTO?>>
{
    private readonly ICompaniesRepository _repository;
    public GetCompanyByIdHandler(ICompaniesRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<GetCompanyByIdDTO?>> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetCompanyById(request.Id);
        var data = GetCompanyByIdDTO.FromEntity(result);
        return Result<GetCompanyByIdDTO?>.Success(data);
    }
}