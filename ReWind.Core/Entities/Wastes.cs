namespace ReWind.Core.Entities;

public class Wastes : BaseEntity
{
    public Wastes(string description)
    {
        Description = description;
    }
    public string Description { get; private set; }
    
    public virtual List<ParkWastes> Parks { get; set; } = [];

}