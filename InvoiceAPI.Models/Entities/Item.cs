using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceAPI.Models.Entities
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }
        

        //public decimal Price { get; set; }
        

        //public int Quantity { get; set; }
        
        //public decimal Total => Price * Quantity;
        
        

        
        //public decimal Discount { get; set; }
        
        //public decimal Net => Total - Total * Discount;
        
        
    
        public virtual List<Unit> Units { get; set; }




        [ForeignKey(nameof(Store))]
        public int? StoreId { get; set; }
        public virtual Store Store { get; set; }
    }
}