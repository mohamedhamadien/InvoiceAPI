using InvoiceAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPI.Models.Dtos
{
    public class UnitDtoCreate
    {
        public string Name { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public decimal Price { get; set; }


        public decimal Total => Price * Quantity;



        public decimal Net => Total - Total * Discount;

        public static Unit ConvertToObj(UnitDtoCreate dtoUpdate)
        {
            return new Unit
            {

                Name = dtoUpdate.Name,
                ItemId = dtoUpdate.ItemId
                ,
                Price = dtoUpdate.Price,
                Quantity = dtoUpdate.Quantity,
                Discount = dtoUpdate.Discount


            };
        }
    }
}
