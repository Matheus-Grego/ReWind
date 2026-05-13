using ReWind.Core.Entities;
using ReWind.Core.Enums;

namespace ReWind.Application.DTOs;

public class ParkWastesDTO
{
    public ParkWastesDTO(Guid id,
        string description,
        decimal? pricePerTon,
        decimal quantityEstimated,
        WasteCalculationEnum wasteCalculationType,
        decimal? co2ReductionTons)
    {
        Id = id;
        Description = description;
        PricePerTon = pricePerTon;
        QuantityEstimated = quantityEstimated;
        WasteCalculationType = wasteCalculationType.ToString();
        CO2ReductionTons = co2ReductionTons;
    }

    public Guid Id { get; set; }
    public string Description { get; set; }
    public decimal? PricePerTon { get; set; }
    public decimal QuantityEstimated { get; set; }
    public string WasteCalculationType { get; set; }
    public decimal? CO2ReductionTons { get; set; }

    public static ParkWastesDTO FromEntity(ParkWastes parkWastes) => 
        new (parkWastes.Id, parkWastes.Waste.Description, parkWastes.PricePerTon, parkWastes.QuantityEstimated, parkWastes.WasteCalculationType, parkWastes.CO2ReductionTons);
}