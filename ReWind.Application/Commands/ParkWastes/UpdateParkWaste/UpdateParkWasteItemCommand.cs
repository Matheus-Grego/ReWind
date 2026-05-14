namespace ReWind.Application.Commands.ParkWastes.UpdateParkWaste;

public class UpdateParkWasteItemCommand
{
    public Guid Id { get; set; }
    public decimal Quantity { get; set; }
    public decimal PricePerTon { get; set; }
}