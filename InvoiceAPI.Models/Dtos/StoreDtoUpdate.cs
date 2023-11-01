using InvoiceAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPI.Models.Dtos
{
    public class StoreDtoUpdate:StoreDtoCreate
    {
        public int Id { get; set; }

        public static Store ConvertToObj(StoreDtoUpdate dtoUpdate)
        {
            return new Store
            {
                Id = dtoUpdate.Id,
                Name = dtoUpdate.Name
            };
        }
    }
}
