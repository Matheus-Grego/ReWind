using ReWind.Core.Enums;

namespace ReWind.Application.DTOs;

public class GetAllParksDTO
{
    public string State { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public decimal? TotalCO2ReductionTons { get; set; }
    public CurtailmentRiskLevelEnum? CurtailmentRiskLevel { get; set; }
    public OriginEnum Origin { get; set; }
    public ParkPhaseEnum ParkPhase { get; set; }
    public decimal? GrantedPowerKw { get; set; }
    public decimal? InspectedPowerKw { get; set; }
}