using MediatR;
using ReWind.Application.Common.Result;

namespace ReWind.Application.Commands.ParkWastes.UpdateParkWaste;

public class UpdateParkWasteCommand : IRequest<Result>
{
    public List<UpdateParkWasteItemCommand> Items { get; set; }
}

