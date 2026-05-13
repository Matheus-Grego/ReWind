using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;
using ReWind.Core.IRepositories;

namespace ReWind.Application.Queries.Parks.GetAllParks;

public class GetAllParksHandler : IRequestHandler<GetAllParksQuery, Result<List<GetAllParksDTO>>>
{
    private readonly IParksRepository _repository;
    public GetAllParksHandler(IParksRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<List<GetAllParksDTO>>> Handle(GetAllParksQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetAllParks();
        var data = entity.Select(x => GetAllParksDTO.FromEntity(x)).ToList();
        return Result<List<GetAllParksDTO>>.Success(data);
    }
}