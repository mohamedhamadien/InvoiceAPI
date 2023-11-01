using InvoiceAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPI.Models.Dtos
{
    public class InvoiceDtoCreate
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string Store { get; set; }
        public int ItemId { get; set; }
        public int StorId { get; set; }

        public string itmname { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalDicound { get; set; }
        // public virtual ICollection<Item> Items { get; set; }
        //  public decimal Total => Items != null ? Items.Sum(x => x.Total) : 0;

        public static Invoice ConvertToObj(InvoiceDtoCreate dtoCreate)
        {
            return new Invoice
            {
                Date = dtoCreate.Date,
                Store = dtoCreate.Store,
                StoreId= dtoCreate.StorId,
                UserId = dtoCreate.ItemId,
                 Price= dtoCreate.Price,
                 Quantity=dtoCreate.Quantity,
                 Total=dtoCreate.TotalPrice,
                 TotalDicound=dtoCreate.TotalDicound,   

              

              
            };
        }
    }
}
