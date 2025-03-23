namespace RCMS.Domain.Entities;

public class Inventory
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public DateTime MovementDate { get; set; } = DateTime.UtcNow;
    public string MovementType { get; set; } // Type of movement = Entry or departure

    public int PartId { get; set; }
    public Part Part { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
}