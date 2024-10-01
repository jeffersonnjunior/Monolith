using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Infrastructure.Mappings;

public class SeatsMap : IEntityTypeConfiguration<Seats>
{
    public void Configure(EntityTypeBuilder<Seats> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.SeatNumber)
            .IsRequired();

        builder.Property(s => s.RowLetter)
            .IsRequired()
            .HasMaxLength(5);

        builder.Property(s => s.ScreenId)
            .IsRequired();

        builder.HasOne(s => s.Screen)
            .WithMany(screen => screen.Seats)
            .HasForeignKey(s => s.ScreenId);

        builder.HasMany(s => s.Tickets)
            .WithOne(ticket => ticket.Seat)
            .HasForeignKey(ticket => ticket.SeatId);
    }
}