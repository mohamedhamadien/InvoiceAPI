using InvoiceAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPI.Models.Dtos
{
    public class StoreDtoCreate
    {
        public string Name { get; set; }

        public static Store ConvertToObj(StoreDtoCreate dtoUpdate)
        {
            return new Store()
            {
                
                Name = dtoUpdate.Name
            };
        }
    }
}
