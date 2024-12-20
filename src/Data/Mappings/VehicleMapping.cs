using InheritanceEntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InheritanceEntityFramework.Data.Mappings;

class VehicleMapping : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.CreatedAt);

        builder.Property(p => p.Brand)
            .IsRequired()
            .HasColumnType("varchar(255)");

        builder.Property(p => p.Model)
            .IsRequired()
            .HasColumnType("varchar(255)"); ;

        builder.ToTable("Vehicles");
    }
}
