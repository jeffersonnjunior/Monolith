using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mappings;

public class AddressMap : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id)
               .ValueGeneratedNever()
               .IsRequired();

        builder.Property(a => a.Street)
               .HasMaxLength(255)
               .IsRequired();

        builder.Property(a => a.UnitNumber)
               .HasMaxLength(50)
               .IsRequired();

        builder.Property(a => a.PostalCode)
               .HasMaxLength(20)
               .IsRequired();
    }
}