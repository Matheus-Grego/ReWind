using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;

namespace ReWind.Application.Queries.Parks.GetAllParks;

public class GetAllParksQuery : IRequest<Result<List<GetAllParksDTO>>>
{
    
}