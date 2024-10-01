using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Infrastructure.Mappings;

public class FilmsMap : IEntityTypeConfiguration<Films>
{
    public void Configure(EntityTypeBuilder<Films> builder)
    {
        builder.HasKey(f => f.Id);

        builder.Property(f => f.Id)
               .ValueGeneratedNever()
               .IsRequired();

        builder.Property(f => f.Name)
               .HasMaxLength(255)
               .IsRequired();

        builder.Property(f => f.Duration)
               .IsRequired();

        builder.Property(f => f.AgeRange)
               .IsRequired();

        builder.Property(f => f.FilmGenres)
               .IsRequired();

        builder.HasMany(f => f.Sessions)
               .WithOne(s => s.Film)
               .HasForeignKey(s => s.FilmId);
    }
}