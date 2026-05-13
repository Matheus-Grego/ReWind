using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;

namespace ReWind.Application.Queries.Parks.GetParkById;

public class GetParkByIdQuery : IRequest<Result<GetParkByIdDTO>>
{
    
}