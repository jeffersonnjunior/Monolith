using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mappings;

public class SessionsMap : IEntityTypeConfiguration<Sessions>
{
    public void Configure(EntityTypeBuilder<Sessions> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.SessionTime)
            .IsRequired();

        builder.Property(s => s.FilmId)
            .IsRequired();

        builder.Property(s => s.Languagem)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.Format)
            .IsRequired();

        builder.HasOne(s => s.Film)
            .WithMany(f => f.Sessions)
            .HasForeignKey(s => s.FilmId);

        builder.HasMany(s => s.Tickets)
            .WithOne(ticket => ticket.Session)
            .HasForeignKey(ticket => ticket.SessionId);
    }
}