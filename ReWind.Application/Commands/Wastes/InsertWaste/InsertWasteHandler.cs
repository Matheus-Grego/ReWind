using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Core.IRepositories;

namespace ReWind.Application.Commands.Wastes.InsertWaste;

public class InsertWasteHandler : IRequestHandler<InsertWasteCommand, Result>
{
    private readonly IWastesRepository _repository;
    public InsertWasteHandler(IWastesRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(InsertWasteCommand request, CancellationToken cancellationToken)
    {
        await _repository.InsertWaste(new Core.Entities.Wastes(request.Description));
        return Result.Success;
    }
}