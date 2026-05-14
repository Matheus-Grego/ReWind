using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;

namespace ReWind.Application.Queries.ParkWastes.GetParkWasteById;

public class GetParkWasteByIdQuery : IRequest<Result<GetParkWasteByIdDTO>>
{
    public GetParkWasteByIdQuery(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; private set; }
}