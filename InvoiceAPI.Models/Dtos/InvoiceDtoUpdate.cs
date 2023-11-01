using InvoiceAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPI.Models.Dtos
{
    public class InvoiceDtoUpdate : InvoiceDtoCreate
    {
        public int Id { get; set; }
     
        public static Invoice ConvertToObj(InvoiceDtoUpdate dtoCreate)
        {
            return new Invoice
            {
                Date = dtoCreate.Date,
                Store = dtoCreate.Store,
                StoreId = dtoCreate.StorId,
                UserId = dtoCreate.ItemId,
                Price = dtoCreate.Price,
                Quantity = dtoCreate.Quantity,
                Total = dtoCreate.TotalPrice,
            };
        }
    }
}
