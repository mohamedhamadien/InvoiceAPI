using InvoiceAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPI.Models.Dtos
{
    public class UnitDtoUpdate:UnitDtoCreate
    {
        public int Id { get; set; }
        public int ItemId { get; set; }


        public static Unit ConvertToObj(UnitDtoUpdate dtoUpdate)
        {
            return new Unit
            {
              
                ItemId = dtoUpdate.ItemId,


                Name = dtoUpdate.Name
                ,
                Price = dtoUpdate.Price,
                Quantity = dtoUpdate.Quantity,
                Discount = dtoUpdate.Discount

            };
        }
    }
}
