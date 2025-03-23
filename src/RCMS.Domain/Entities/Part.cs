namespace RCMS.Domain.Entities;

public class Part
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; }

    public ICollection<Inventory> Inventory { get; set; } = new List<Inventory>();
}