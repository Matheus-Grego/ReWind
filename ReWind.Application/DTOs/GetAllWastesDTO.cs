using ReWind.Core.Entities;

namespace ReWind.Application.DTOs;

public class GetAllWastesDTO
{
    public GetAllWastesDTO(Guid id, string description)
    {
        Id = id;
        Description =  description;
    }
    public Guid Id { get; set; }
    public string Description { get; set; }
    public static GetAllWastesDTO FromEntity(Wastes wastes) => new (wastes.Id, wastes.Description);

}