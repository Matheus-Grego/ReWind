using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;

namespace ReWind.Application.Queries.Companies.GetAllCompanies;

public class GetAllCompaniesQuery : IRequest<Result<List<GetAllCompaniesDTO>>>
{
    
}