namespace Domain.Entities;

public class MovieTheaters
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public Guid AddressId { get; set; }
    public virtual Address Address { get; set; }
    public virtual ICollection<Screens> Screens { get; set; }
}
