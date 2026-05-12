using ReWind.Core.Enums;

namespace ReWind.Core.Entities;

public class Parks : BaseEntity
{
    public string Name { get; set; }
    public string CNPJ { get; set; }
    public string CEG { get; set; }
    public string State { get; set; }
    public string Source { get; set; }
    public ParkPhaseEnum ParkPhase { get; set; }
    public OriginEnum Origin { get; set; }
    public EnergySourcesEnum EnergySourceType { get; set; }
    public OperationTypeEnum OperationType { get; set; }
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
    public virtual List<ParkOwners> Owners { get; set; }
    public string? SubBasin { get; set; }
    public string? Municipalities { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? ZipCode { get; set; }
    public string? Email { get; set; }
    public decimal? TotalCO2ReductionTons { get; set; }
    public CurtailmentRiskLevelEnum? CurtailmentRiskLevel { get; set; }
    
}