using InheritanceEntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InheritanceEntityFramework.Data.Mappings;

class MotorCycleMapping : IEntityTypeConfiguration<MotorCycle>
{
    public void Configure(EntityTypeBuilder<MotorCycle> builder)
    {
        builder.ToTable("Motorcycles");
    }
}
