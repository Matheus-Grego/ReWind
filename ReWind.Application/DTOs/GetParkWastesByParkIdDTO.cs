using ReWind.Core.Entities;

namespace ReWind.Application.DTOs;

public class GetParkWastesByParkIdDTO
{
    public GetParkWastesByParkIdDTO(Guid id, string wasteDescription, decimal quantityEstimated, decimal? pricePerTon)
    {
        Id = id;
        WasteDescription = wasteDescription;
        QuantityEstimated = quantityEstimated;
        PricePerTon = pricePerTon;
    }

    public Guid Id { get; set; }
    public string WasteDescription { get; set; }
    public decimal QuantityEstimated { get; set; }
    public decimal? PricePerTon { get; set; }
    
    public static GetParkWastesByParkIdDTO FromEntity(ParkWastes parkWastes) => new (parkWastes.Id, parkWastes.Waste.Description, parkWastes.QuantityEstimated, parkWastes.PricePerTon); 

}