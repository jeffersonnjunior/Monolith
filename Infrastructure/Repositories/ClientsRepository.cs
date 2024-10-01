using Domain.Entities;
using Infrastructure.Context;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class ClientsRepository : BaseRepository<Clients>, IClientsRepository
{
    public ClientsRepository(AppDbContext context) : base(context)
    {
    }
}