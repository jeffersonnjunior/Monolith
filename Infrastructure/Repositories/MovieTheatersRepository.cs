using Domain.Entities;
using Infrastructure.Context;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class MovieTheatersRepository : BaseRepository<MovieTheaters>, IMovieTheatersRepository
{
    public MovieTheatersRepository(AppDbContext context) : base(context)
    {
    }
}

