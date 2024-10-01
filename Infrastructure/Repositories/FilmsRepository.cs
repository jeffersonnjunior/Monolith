using Domain.Entities;
using Infrastructure.Context;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class FilmsRepository : BaseRepository<Films>, IFilmsRepository
{
    public FilmsRepository( AppDbContext context) : base(context)
    {
    }
}