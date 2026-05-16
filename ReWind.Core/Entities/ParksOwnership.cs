namespace ReWind.Core.Entities;

public class ParksOwnership : BaseEntity
{
    public Guid ParkId { get; set; }
    public Guid OwnerId { get; set; }
    public decimal Percentage { get; set; }
    public virtual Parks Park { get; set; }
    public virtual ParkOwner Owner { get; set; }
}