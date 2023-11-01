using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceAPI.Models.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Store { get; set; }
        public virtual ICollection<Unit> Items { get; set; }
        public decimal Total { get; set; }
        public decimal TotalDicound { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public int UserId { get; set; }
        [ForeignKey("store")]

        public int StoreId { get; set; }
        public virtual Store  store { get; set; }


    }
}
