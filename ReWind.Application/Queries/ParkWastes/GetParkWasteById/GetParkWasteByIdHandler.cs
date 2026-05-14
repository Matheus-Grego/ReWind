using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;
using ReWind.Core.IRepositories;

namespace ReWind.Application.Queries.ParkWastes.GetParkWasteById;

public class GetParkWasteByIdHandler : IRequestHandler<GetParkWasteByIdQuery, Result<GetParkWasteByIdDTO>>
{
    private readonly IParkWastesRepository _repository;
    public GetParkWasteByIdHandler(IParkWastesRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<GetParkWasteByIdDTO>> Handle(GetParkWasteByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetParkWasteById(request.Id);
        var data = GetParkWasteByIdDTO.FromEntity(result);
        return Result<GetParkWasteByIdDTO>.Success(data);
    }
}