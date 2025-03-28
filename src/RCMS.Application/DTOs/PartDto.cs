﻿namespace RCMS.DTOs;

public class PartDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public required int Stock { get; set; }
}