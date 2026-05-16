using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;

namespace ReWind.Application.Queries.Companies.GetCompanyById;

public class GetCompanyByIdQuery : IRequest<Result<GetCompanyByIdDTO?>>
{
    public GetCompanyByIdQuery(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; private set; }
    
}