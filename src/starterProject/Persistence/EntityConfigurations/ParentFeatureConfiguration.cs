using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class ParentFeatureConfiguration : IEntityTypeConfiguration<ParentFeature>
{
    public void Configure(EntityTypeBuilder<ParentFeature> builder)
    {
        builder.ToTable("ParentFeatures").HasKey(pf => pf.Id);

        builder.Property(pf => pf.Id).HasColumnName("Id").IsRequired();
        builder.Property(pf => pf.FeatureName).HasColumnName("FeatureName");
        builder.Property(pf => pf.ParentId).HasColumnName("ParentId");
        builder.Property(pf => pf.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(pf => pf.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(pf => pf.DeletedDate).HasColumnName("DeletedDate");
        builder.HasOne(pf => pf.Parent)
            .WithOne(p => p.ParentFeature)
            .HasForeignKey<ParentFeature>(pf => pf.ParentId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasQueryFilter(pf => !pf.DeletedDate.HasValue);
    }
}