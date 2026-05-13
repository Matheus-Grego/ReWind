using Microsoft.EntityFrameworkCore;
using ReWind.Core.Entities;

namespace ReWind.Infrastructure.Persistance;

public class ReWindDBContext : DbContext
{
    public readonly DbContextOptions<ReWindDBContext> _dbContextOptions;

    public ReWindDBContext(DbContextOptions<ReWindDBContext> options) : base(options)
    {
        
    }
    
    public DbSet<Companies> Companies { get; set; }
    public DbSet<CompanyOwner>  CompanyOwners { get; set; }
    public DbSet<CompanyOwnership> CompanyOwnerships { get; set; }
    
    public DbSet<ParkOwner> ParkOwners { get; set; }
    public DbSet<Parks> Parks { get; set; }
    public DbSet<ParksOwnership> ParksOwnerships { get; set; }
    
    public DbSet<ParkWastes> ParkWastes { get; set; }
    public DbSet<Wastes> Wastes { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Companies>(e =>
        {
            e.HasKey(x => x.Id);

            e.HasMany(x => x.Owners)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        builder.Entity<CompanyOwner>(e =>
        {
            e.HasKey(x => x.Id);

            e.HasMany(x => x.Companies)
                .WithOne(x => x.CompanyOwner)
                .HasForeignKey(x => x.CompanyOwnerId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        builder.Entity<CompanyOwnership>(e =>
        {
            e.HasKey(x => x.Id);

            e.Property(x => x.Percentage)
                .HasPrecision(18, 2);

            e.HasOne(x => x.Company)
                .WithMany(x => x.Owners)
                .HasForeignKey(x => x.CompanyId);

            e.HasOne(x => x.CompanyOwner)
                .WithMany(x => x.Companies)
                .HasForeignKey(x => x.CompanyOwnerId);
        });

        builder.Entity<ParkOwner>(e =>
        {
            e.HasKey(x => x.Id);

            e.HasMany(x => x.Parks)
                .WithOne(x => x.Owner)
                .HasForeignKey(x => x.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        builder.Entity<Parks>(e =>
        {
            e.HasKey(x => x.Id);

            e.HasMany(x => x.Owners)
                .WithOne(x => x.Park)
                .HasForeignKey(x => x.ParkId)
                .OnDelete(DeleteBehavior.Cascade);

            e.HasMany(x => x.Wastes)
                .WithOne(x => x.Park)
                .HasForeignKey(x => x.ParkId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        builder.Entity<ParksOwnership>(e =>
        {
            e.HasKey(x => x.Id);
            
            e.HasOne(x => x.Park)
                .WithMany(x => x.Owners)
                .HasForeignKey(x => x.ParkId);

            e.HasOne(x => x.Owner)
                .WithMany(x => x.Parks)
                .HasForeignKey(x => x.OwnerId);
        });

        builder.Entity<ParkWastes>(e =>
        {
            e.HasKey(x => x.Id);

            e.HasOne(x => x.Park)
                .WithMany(x => x.Wastes)
                .HasForeignKey(x => x.ParkId);

            e.HasOne(x => x.Waste)
                .WithMany(x => x.Parks)
                .HasForeignKey(x => x.WasteId);
        });

        builder.Entity<Wastes>(e =>
        {
            e.HasKey(x => x.Id);
        });

        base.OnModelCreating(builder);
    }
    
}