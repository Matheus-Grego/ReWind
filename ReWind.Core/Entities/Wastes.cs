namespace ReWind.Core.Entities;

public class Wastes : BaseEntity
{
    public Wastes(string description)
    {
        Description = description;
    }
    public string Description { get; private set; }
}