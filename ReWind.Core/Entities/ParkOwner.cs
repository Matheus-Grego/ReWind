namespace ReWind.Core.Entities;

public class ParkOwner : BaseEntity
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
    public virtual List<ParksOwnership> Parks { get; set; } = [];
}