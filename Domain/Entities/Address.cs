﻿namespace Domain.Entities;

public class Address
{
    public Guid Id { get; set; }
    public required string Street { get; set; }
    public required string UnitNumber { get; set; }
    public required string PostalCode { get; set; }
}