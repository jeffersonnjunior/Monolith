using Domain.Entities;
using Infrastructure.Context;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class SessionsRepository : BaseRepository<Sessions>, ISessionsRepository
{
    public SessionsRepository(AppDbContext context) : base(context)
    {
    }
}