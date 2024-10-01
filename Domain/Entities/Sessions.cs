using Domain.Enums;

namespace Domain.Entities;

public class Sessions
{
    public Guid Id { get; set; }
    public DateTime SessionTime { get; set; }
    public Guid FilmId { get; set; }
    public required string Languagem { get; set; }
    public Format Format{ get; set; }
    public virtual Films Film { get; set; }
    public virtual ICollection<Tickets> Tickets { get; set; }
}
