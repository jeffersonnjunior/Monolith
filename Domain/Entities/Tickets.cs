﻿namespace Domain.Entities;

public class Tickets
{
    public Guid Id { get; set; }
    public Guid SessionId { get; set; }
    public Guid SeatId { get; set; }
    public Guid ClientId { get; set; }
    public virtual Sessions Session { get; set; }
    public virtual Seats Seat { get; set; }
    public virtual Clients Client{ get; set; }
}
