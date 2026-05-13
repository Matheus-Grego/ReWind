using ReWind.Core.Entities;

namespace ReWind.Application.DTOs;

public class ParksOwnershipDTO
{
    public ParksOwnershipDTO(string companyName, decimal? percentage)
    {
        CompanyName = companyName;
        Percentage = percentage;
    }
    public string CompanyName { get; set; }
    public decimal? Percentage { get; set; }
    
    public static ParksOwnershipDTO FromEntity(ParksOwnership parkOwnership) => new(parkOwnership.Owner.FullName, parkOwnership.Percentage);
}