using ReWind.Core.Enums;

namespace ReWind.Core.Entities;

public class ParkWastes : BaseEntity
{
    public Guid ParkId { get; set; }
    public Guid WasteId { get; set; }
    public decimal? PricePerTon { get; set; }
    public decimal QuantityEstimated { get; set; }
    public WasteCalculationEnum WasteCalculationType { get; set; }
    public decimal? CO2ReductionTons { get; set; }
    
    public virtual Parks Park { get; set; }
    public virtual Wastes Waste { get; set; }
}