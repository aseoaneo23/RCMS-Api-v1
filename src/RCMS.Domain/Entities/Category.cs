namespace RCMS.Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }

    public ICollection<Part> Parts { get; set; } = new List<Part>();
}