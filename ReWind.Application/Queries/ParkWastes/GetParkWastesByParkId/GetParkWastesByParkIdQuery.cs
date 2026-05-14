using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;

namespace ReWind.Application.Queries.ParkWastes.GetParkWastesByParkId;

public class GetParkWastesByParkIdQuery : IRequest<Result<List<GetParkWastesByParkIdDTO>>>
{
    public GetParkWastesByParkIdQuery(Guid parkId)
    {
        ParkId = parkId;
    }
    public Guid ParkId { get; set; }
    
}