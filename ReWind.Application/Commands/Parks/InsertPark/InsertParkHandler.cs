using MediatR;
using ReWind.Application.Common.Result;
using ReWind.Core.Enums;
using ReWind.Core.IRepositories;

namespace ReWind.Application.Commands.Parks.InsertPark;

public class InsertParkHandler : IRequestHandler<InsertParkCommand, Result>
{
    private readonly IParksRepository _repository;
    public InsertParkHandler(IParksRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(InsertParkCommand request, CancellationToken cancellationToken)
    {
        Core.Entities.Parks entity = new Core.Entities.Parks
        {
            Name = request.Name,
            CNPJ = request.CNPJ,
            CEG = request.CEG,
            State = request.State,
            Source = request.Source,
            ParkPhase = request.ParkPhase,
            Origin = request.Origin,
            EnergySourceType = request.EnergySourceType,
            OperationType = request.OperationType,
            FinalFuel = request.FinalFuel,
            OperationStartDate = request.OperationStartDate,
            GrantedPowerKw = request.GrantedPowerKw,
            InspectedPowerKw = request.InspectedPowerKw,
            PhysicalGuaranteeKw = request.PhysicalGuaranteeKw,
            QualifiedGeneration = request.QualifiedGeneration,
            LicenseStartDate = request.LicenseStartDate,
            LicenseEndDate = request.LicenseEndDate,
            OwnershipRelation = request.OwnershipRelation,
            SubBasin = request.SubBasin,
            Municipalities = request.Municipalities,
            Address1 = request.Address1,
            Address2 = request.Address2,
            ZipCode = request.ZipCode,
            Email = request.Email
        };
        await _repository.InsertPark(entity);
        return Result.Success;
    }
}