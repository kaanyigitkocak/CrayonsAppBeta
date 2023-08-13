using Application.Features.OperationClaims.Constants;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
{
    public void Configure(EntityTypeBuilder<OperationClaim> builder)
    {
        builder.ToTable("OperationClaims").HasKey(oc => oc.Id);

        builder.Property(oc => oc.Id).HasColumnName("Id").IsRequired();
        builder.Property(oc => oc.Name).HasColumnName("Name").IsRequired();
        builder.Property(oc => oc.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(oc => oc.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(oc => oc.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(oc => !oc.DeletedDate.HasValue);

        builder.HasMany(oc => oc.UserOperationClaims);

        builder.HasData(getSeeds());
    }

    private HashSet<OperationClaim> getSeeds()
    {
        int id = 0;
        HashSet<OperationClaim> seeds =
            new()
            {
                new OperationClaim { Id = ++id, Name = GeneralOperationClaims.Admin }
            };


        #region ParentFeatures

        seeds.Add(new OperationClaim { Id = ++id, Name = "ParentFeatures.Admin" });

        seeds.Add(new OperationClaim { Id = ++id, Name = "ParentFeatures.Read" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "ParentFeatures.Write" });

        seeds.Add(new OperationClaim { Id = ++id, Name = "ParentFeatures.Add" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "ParentFeatures.Update" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "ParentFeatures.Delete" });

        #endregion


        #region Schools

        seeds.Add(new OperationClaim { Id = ++id, Name = "Schools.Admin" });

        seeds.Add(new OperationClaim { Id = ++id, Name = "Schools.Read" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Schools.Write" });

        seeds.Add(new OperationClaim { Id = ++id, Name = "Schools.Add" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Schools.Update" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Schools.Delete" });

        #endregion

        
        #region Invoices
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Invoices.Admin" });
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Invoices.Read" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Invoices.Write" });
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Invoices.Add" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Invoices.Update" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Invoices.Delete" });
        
        #endregion
        
        
        #region Files
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Files.Admin" });
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Files.Read" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Files.Write" });
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Files.Add" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Files.Update" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Files.Delete" });
        
        #endregion
        
        return seeds;
    }
}
