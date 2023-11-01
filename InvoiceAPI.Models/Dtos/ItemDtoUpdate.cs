using InvoiceAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPI.Models.Dtos
{
    public class ItemDtoUpdate: ItemDtoCreate
    {
        public int Id { get; set; }
        public int storid { get; set; }
      

        public static Item ConvertToObj(ItemDtoUpdate dtoUpdate)
        {
            return new Item()
            { StoreId= dtoUpdate.storid,
                Id =dtoUpdate.Id,
                Name = dtoUpdate.Name,
             
            };
        }
    }
}
