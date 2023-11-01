using InvoiceAPI.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPI.Models.Interfaces
{
    public interface IItem
    {
       IEnumerable<ItemDtoUpdate> GetAllAsync();
   ItemDtoUpdate GetByIdAsync(int id);
        Task InsertAsync(ItemDtoCreate obj);
        Task UpdateAsync(ItemDtoUpdate obj);
        void Delete(int id);
    }
}
