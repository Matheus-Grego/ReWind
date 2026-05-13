using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;
using ReWind.Application.Queries.Parks.GetAllParks;

namespace ReWind.Application.Queries.Parks.GetParkById;

public class GetParkByIdHandler : IRequestHandler<GetParkByIdQuery, Result<GetParkByIdDTO>>
{
    public Task<Result<GetParkByIdDTO>> Handle(GetParkByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}