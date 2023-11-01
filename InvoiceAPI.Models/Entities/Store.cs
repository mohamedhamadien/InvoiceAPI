using System.ComponentModel.DataAnnotations;

namespace InvoiceAPI.Models.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Item> Items { get; set; }

        public virtual List<Invoice> Units { get; set; }

    }
}