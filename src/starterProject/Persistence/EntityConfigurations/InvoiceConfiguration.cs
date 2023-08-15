using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using File = Domain.Entities.File;

namespace Persistence.EntityConfigurations;

public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.ToTable("Invoices").HasKey(e => e.Id);

        builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
        builder.Property(x => x.InvoiceNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.Detail)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(x => x.Amount)
            .IsRequired();

        builder.Property(x => x.IsPaid)
            .IsRequired();

        builder.Property(x => x.DueDate)
            .IsRequired();

        builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(t => t.DeletedDate).HasColumnName("DeletedDate");
        builder.HasOne(e => e.Parent)
           .WithMany(p => p.Invoices)
           .HasForeignKey(e => e.ParentId)
           .OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(e => e.InvoiceFiles)
            .WithOne(e => e.Invoice)
            .HasForeignKey(e => e.InvoiceId)
           .OnDelete(DeleteBehavior.Restrict);
    }
}
