namespace ReWind.Core.Entities;

public class CompanyOwnership : BaseEntity
{
    public Guid CompanyId { get; set; }
    public Guid CompanyOwnerId { get; set; }
    public decimal Percentage { get; set; }
    
    public virtual Companies Company { get; set; }
    public virtual CompanyOwner CompanyOwner { get; set; }
}