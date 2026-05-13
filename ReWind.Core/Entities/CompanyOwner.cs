namespace ReWind.Core.Entities;

public class CompanyOwner : BaseEntity
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
    public virtual List<CompanyOwnership> Companies { get; set; } = [];
}