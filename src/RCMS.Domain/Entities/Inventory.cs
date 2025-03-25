namespace RCMS.Domain.Entities;

public class Inventory
{
    public int Id { get; set; }
    public required int Quantity { get; set; }
    public DateTime MovementDate { get; set; } = DateTime.UtcNow;
    public required string MovementType { get; set; } // Type of movement = Entry or departure

    public int PartId { get; set; }
    public required Part Part { get; set; }
    
    public int UserId { get; set; }
    
    public required User User { get; set; }
}