using MediatR;
using ReWind.Application.Common.Result;

namespace ReWind.Application.Commands.Wastes.InsertWaste;

public class InsertWasteCommand : IRequest<Result>
{
    public InsertWasteCommand(string description)
    {
        Description = description;
    }
    public string Description { get; }
}