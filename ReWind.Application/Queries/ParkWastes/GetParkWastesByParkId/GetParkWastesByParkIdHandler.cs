using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;
using ReWind.Core.IRepositories;

namespace ReWind.Application.Queries.ParkWastes.GetParkWastesByParkId;

public class GetParkWastesByParkIdHandler : IRequestHandler<GetParkWastesByParkIdQuery, Result<List<GetParkWastesByParkIdDTO>>>
{
    private readonly IParkWastesRepository _repository;
    public GetParkWastesByParkIdHandler(IParkWastesRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<List<GetParkWastesByParkIdDTO>>> Handle(GetParkWastesByParkIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetParkWastesByParkId(request.ParkId);
        var data = result.Select(x => GetParkWastesByParkIdDTO.FromEntity(x)).ToList();
        return Result<List<GetParkWastesByParkIdDTO>>.Success(data);
    }
}