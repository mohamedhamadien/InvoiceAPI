using InvoiceAPI.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPI.Models.Interfaces
{
    public interface IUnit
    {
         IEnumerable<UnitDtoUpdate> GetAllAsync();
         UnitDtoUpdate GetByIdAsync(int id);
        Task InsertAsync(UnitDtoCreate obj);
        Task UpdateAsync(UnitDtoUpdate obj);
        void Delete(int id);
    }
}
