using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class InvoiceFileConfiguration : IEntityTypeConfiguration<InvoiceFile>
{
    public void Configure(EntityTypeBuilder<InvoiceFile> builder)
    {
        
        builder.HasOne(e => e.Invoice)
            .WithMany(i => i.InvoiceFiles)
           .HasForeignKey(e => e.InvoiceId)
           .OnDelete(DeleteBehavior.Cascade); // Set the appropriate delete behavior

        // Add any other configurations specific to InvoiceFile entity
    }
}
