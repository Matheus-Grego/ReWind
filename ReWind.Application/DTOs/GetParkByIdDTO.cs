
using ReWind.Core.Entities;

namespace ReWind.Application.DTOs;

public class GetParkByIdDTO
{
    public string Name { get; set; }
    public string? CNPJ { get; set; }
    public string CEG { get; set; }
    public string State { get; set; }
    public string Source { get; set; }
    public string ParkPhase { get; set; }
    public string Origin { get; set; }
    public string EnergySourceType { get; set; }
    public string OperationType { get; set; }
    public string FinalFuel { get; set; }
    public DateTime? OperationStartDate { get; set; }
    public decimal? GrantedPowerKw { get; set; }
    public decimal? InspectedPowerKw { get; set; }
    public decimal? PhysicalGuaranteeKw { get; set; }
    public bool? QualifiedGeneration { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public DateTime? LicenseStartDate { get; set; }
    public DateTime? LicenseEndDate { get; set; }
    public string OwnershipRelation { get; set; }
    public string? SubBasin { get; set; }
    public string? Municipalities { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? ZipCode { get; set; }
    public string? Email { get; set; }
    public decimal? TotalCO2ReductionTons { get; set; }
    public string? CurtailmentRiskLevel { get; set; }
    public virtual List<ParksOwnershipDTO?> Owners { get; set; } = [];
    public virtual List<ParkWastesDTO> Wastes { get; set; } = [];
    
    public static GetParkByIdDTO FromEntity(Parks park) => new()
    {
        Name = park.Name,
        CNPJ = park.CNPJ,
        CEG = park.CEG,
        State = park.State,
        Source = park.Source,
        ParkPhase = park.ParkPhase.ToString(),
        Origin = park.Origin.ToString(),
        EnergySourceType = park.EnergySourceType.ToString(),
        OperationType = park.OperationType.ToString(),
        FinalFuel = park.FinalFuel,
        OperationStartDate = park.OperationStartDate,
        GrantedPowerKw = park.GrantedPowerKw,
        InspectedPowerKw = park.InspectedPowerKw,
        PhysicalGuaranteeKw = park.PhysicalGuaranteeKw,
        QualifiedGeneration = park.QualifiedGeneration,
        Latitude = park.Latitude,
        Longitude = park.Longitude,
        LicenseStartDate = park.LicenseStartDate,
        LicenseEndDate = park.LicenseEndDate,
        OwnershipRelation = park.OwnershipRelation,
        SubBasin = park.SubBasin,
        Municipalities = park.Municipalities,
        Address1 = park.Address1,
        Address2 = park.Address2,
        ZipCode = park.ZipCode,
        Email = park.Email,
        TotalCO2ReductionTons = park.TotalCO2ReductionTons,
        CurtailmentRiskLevel = park.CurtailmentRiskLevel?.ToString(),
        Owners = park.Owners?
            .Select(o => o != null ? ParksOwnershipDTO.FromEntity(o) : null)
            .ToList() ?? [],
        Wastes = park.Wastes?
            .Select(ParkWastesDTO.FromEntity)
            .ToList() ?? [],
    };
}