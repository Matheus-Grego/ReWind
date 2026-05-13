using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;
using ReWind.Core.IRepositories;

namespace ReWind.Application.Queries.Wastes.GetAllWastes;

public class GetAllWastesHandler : IRequestHandler<GetAllWastesQuery, Result<List<GetAllWastesDTO>>>
{
    private readonly IWastesRepository _repository;
    public GetAllWastesHandler(IWastesRepository parksRepository)
    {
        _repository = parksRepository;
    }
    
    public async Task<Result<List<GetAllWastesDTO>>> Handle(GetAllWastesQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAllWastes();
        var data = result.Select(x => GetAllWastesDTO.FromEntity(x)).ToList();
        return Result<List<GetAllWastesDTO>>.Success(data);
    }
}