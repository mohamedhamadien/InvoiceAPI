using InvoiceAPI.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

public class Unit
{
    public int Quantity { get; set; }
    public int Discount { get; set; }
    public decimal Price { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }

    [ForeignKey("Item")]
    public int ItemId { get; set; }
    public virtual Item Item { get; set; }
}
