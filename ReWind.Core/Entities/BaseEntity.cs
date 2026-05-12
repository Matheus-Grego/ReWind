namespace ReWind.Core.Entities;

public class BaseEntity
{
    public BaseEntity()
    {
        Id = Guid.NewGuid();
        CreationDate = DateTime.Now;
        IsDeleted = false;
    }
    public Guid Id { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public bool IsDeleted { get; set; }

    public void Delete()
    {
        IsDeleted = true;
    }
    public void Update()
    {
        UpdateDate = DateTime.Now;
    }
}