using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Application.DTOs;
using ReWind.Application.Queries.Parks.GetAllParks;
using ReWind.Core.IRepositories;

namespace ReWind.Application.Queries.Parks.GetParkById;

public class GetParkByIdHandler : IRequestHandler<GetParkByIdQuery, Result<GetParkByIdDTO>>
{
    private readonly IParksRepository _repository;
    public GetParkByIdHandler(IParksRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<GetParkByIdDTO>> Handle(GetParkByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetParkById(request.Id);
        var data = GetParkByIdDTO.FromEntity(result);
        return Result<GetParkByIdDTO>.Success(data);
    }
}