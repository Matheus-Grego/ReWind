using Microsoft.IdentityModel.Tokens;
using ReWind.Core.Entities;
using ReWind.Core.Enums;

namespace ReWind.Application.DTOs;

public class GetAllParksDTO
{
    public GetAllParksDTO(
        Guid id,
        string state,
        double? latitude,
        double? longitude,
        decimal? totalCo2ReductionTons,
        CurtailmentRiskLevelEnum? curtailmentRiskLevel,
        OriginEnum origin,
        ParkPhaseEnum parkPhase,
        decimal? grantedPowerKw,
        decimal? inspectedPowerKw)
    {
        Id = id;
        State = state;
        Latitude = latitude;
        Longitude = longitude;
        TotalCO2ReductionTons = totalCo2ReductionTons;
        CurtailmentRiskLevel = curtailmentRiskLevel.ToString();
        Origin = origin.ToString();
        ParkPhase = parkPhase.ToString();
        GrantedPowerKw = grantedPowerKw;
        InspectedPowerKw = inspectedPowerKw;
    }

    public Guid Id { get; set; }
    public string State { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public decimal? TotalCO2ReductionTons { get; set; }
    public string? CurtailmentRiskLevel { get; set; }
    public string Origin { get; set; }
    public string ParkPhase { get; set; }
    public decimal? GrantedPowerKw { get; set; }
    public decimal? InspectedPowerKw { get; set; }
    
    public static GetAllParksDTO FromEntity(Parks park) => 
        new (park.Id,
            park.State,
            park.Latitude,
            park.Longitude,
            park.TotalCO2ReductionTons,
            park.CurtailmentRiskLevel,
            park.Origin,
            park.ParkPhase,
            park.GrantedPowerKw,
            park.InspectedPowerKw);
}