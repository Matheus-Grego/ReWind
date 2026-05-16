using ReWind.Core.Entities;

namespace ReWind.Application.DTOs;

public class GetAllCompaniesDTO
{
    public string? CompanyGroup { get; set; } 
    public string? LegalName { get; set; } 
    public string? TradeName { get; set; } 
    public string? CNPJ { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Owner { get; set; }
    public string CompanySegment { get; set; }
    public string? CompanyPlantType { get; set; }

    public static GetAllCompaniesDTO FromEntity(Companies entity) => new()
    {
        CompanyGroup = entity.CompanyGroup,
        LegalName =  entity.LegalName,
        TradeName = entity.TradeName,
        CNPJ = entity.CNPJ,
        State = entity.State,
        City = entity.City,
        Address = entity.Address,
        Phone = entity.Phone,
        Email = entity.Email,
        Owner = entity.Owner,
        CompanySegment = entity.CompanySegment.ToString(),
        CompanyPlantType = entity.CompanyPlantType.ToString()
    };
}