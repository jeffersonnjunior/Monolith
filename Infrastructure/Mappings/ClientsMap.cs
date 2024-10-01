using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Infrastructure.Mappings;

public class ClientsMap : IEntityTypeConfiguration<Clients>
{
    public void Configure(EntityTypeBuilder<Clients> builder)
    {
        builder.ToTable("Clients");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Age)
            .HasMaxLength(3);

        builder.HasMany(c => c.Tickets)
            .WithOne(t => t.Client)
            .HasForeignKey(t => t.ClientId);
    }
}