﻿namespace RCMS.Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }

    public ICollection<Part> Parts { get; set; } = new List<Part>();
}