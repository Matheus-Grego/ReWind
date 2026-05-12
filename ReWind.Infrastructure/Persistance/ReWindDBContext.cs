using Microsoft.EntityFrameworkCore;

namespace ReWind.Infrastructure.Persistance;

public class ReWindDBContext : DbContext
{
    public ReWindDBContext(DbContextOptions<ReWindDBContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
    }
}