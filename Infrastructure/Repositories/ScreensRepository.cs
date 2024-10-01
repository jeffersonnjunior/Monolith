using Domain.Entities;
using Infrastructure.Context;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class ScreensRepository : BaseRepository<Screens>, IScreensRepository
{
    public ScreensRepository(AppDbContext context) : base(context)
    {
    }
}
