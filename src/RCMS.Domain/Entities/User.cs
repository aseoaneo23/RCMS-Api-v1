using System.ComponentModel.DataAnnotations;

namespace RCMS.Domain.Entities;

public class User
{
    public int Id{ get; set; }
    public required string Name { get; set; }
    public string ? FirstName { get; set; }
    public required string Email { get; set; }
    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }
    public required string Role { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public bool IsActive { get; set; }
    
    public ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}