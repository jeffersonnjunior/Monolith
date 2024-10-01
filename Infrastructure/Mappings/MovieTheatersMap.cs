using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Infrastructure.Mappings;

public class MovieTheatersMap : IEntityTypeConfiguration<MovieTheaters>
{
    public void Configure(EntityTypeBuilder<MovieTheaters> builder)
    {
        builder.HasKey(mt => mt.Id);

        builder.Property(mt => mt.Id)
               .ValueGeneratedNever()
               .IsRequired();

        builder.Property(mt => mt.Name)
               .HasMaxLength(255)
               .IsRequired();

        builder.Property(mt => mt.AddressId)
               .IsRequired();

        builder.HasOne(mt => mt.Address)
               .WithMany()
               .HasForeignKey(mt => mt.AddressId);
    }
}