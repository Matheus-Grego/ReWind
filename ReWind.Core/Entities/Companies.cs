using ReWind.Core.Enums;

namespace ReWind.Core.Entities;

public class Companies : BaseEntity
{
    public string LegalName { get; set; } 
    public string TradeName { get; set; } 
    public string CNPJ { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Owner { get; set; }
    public CompanySegmentEnum ComapnySegment { get; set; }
    
    public virtual List<CompanyOwnership?> Owners { get; set; } = [];
}