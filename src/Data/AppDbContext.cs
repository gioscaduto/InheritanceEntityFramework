using InheritanceEntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace InheritanceEntityFramework.Data;

class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)  
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
