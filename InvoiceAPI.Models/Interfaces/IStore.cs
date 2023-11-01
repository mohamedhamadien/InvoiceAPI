using InvoiceAPI.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPI.Models.Interfaces
{
    public interface IStore
    {
        
        IEnumerable<StoreDtoUpdate> GetAllAsync();
         StoreDtoUpdate GetByIdAsync(int id);

        Task InsertAsync(StoreDtoCreate obj);
        Task UpdateAsync(StoreDtoUpdate obj);
        void Delete(int id);
    }
}
