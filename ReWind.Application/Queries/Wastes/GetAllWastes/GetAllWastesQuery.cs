using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;

namespace ReWind.Application.Queries.Wastes.GetAllWastes;

public class GetAllWastesQuery : IRequest<Result<List<GetAllWastesDTO>>>
{
    
}