using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Core.Enums;
using ReWind.Core.IRepositories;

namespace ReWind.Application.Commands.ParkWastes.UpdateParkWaste;

public class UpdateParkWasteHandler : IRequestHandler<UpdateParkWasteCommand, Result>
{
    private readonly IParkWastesRepository _repository;
    public UpdateParkWasteHandler(IParkWastesRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(UpdateParkWasteCommand request, CancellationToken cancellationToken)
    {
        List<Core.Entities.ParkWastes> parkWastesList = [];
        
        foreach (var item in request.Items)
        {
            var result = await _repository.GetParkWasteById(item.Id);
            if(item.PricePerTon != null)
                result.PricePerTon = item.PricePerTon;
            if(item.Quantity != null)
                result.QuantityEstimated = item.Quantity;
        
            result.WasteCalculationType = WasteCalculationEnum.Inputed;
            parkWastesList.Add(result);

        }
        await _repository.UpdateParkWaste(parkWastesList);
        return Result.Success;

    }
}