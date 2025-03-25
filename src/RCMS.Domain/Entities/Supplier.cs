namespace RCMS.Domain.Entities;

public class Supplier
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Contact { get; set; }
    public required string Phone { get; set; }
    public required string Email { get; set; }
    public required string Address { get; set; }

    public ICollection<Part> Parts { get; set; } = new List<Part>();
}