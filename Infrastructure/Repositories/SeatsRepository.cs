using Domain.Entities;
using Infrastructure.Context;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class SeatsRepository : BaseRepository<Seats>, ISeatsRepository
{
    public SeatsRepository(AppDbContext context) : base(context)
    {
    }
}