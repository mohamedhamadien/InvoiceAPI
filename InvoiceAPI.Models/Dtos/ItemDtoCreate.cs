using InvoiceAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPI.Models.Dtos
{
    public class ItemDtoCreate
    {
        public string Name { get; set; }
        //public decimal Price { get; set; }


       // public decimal Total => Price * Quantity;



     //   public decimal Net => Total - Total * Discount;

        public static Item ConvertToObj(ItemDtoCreate dtoUpdate)
        {
            return new Item
            {
                Name = dtoUpdate.Name,
                //Price = dtoUpdate.Price,

             

            };
        }
    }
}
