using InvoiceAPI.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPI.Models.Interfaces
{
    public interface IInovcie
    {
        IEnumerable<InvoiceDtoUpdate> GetAllAsync();
      
        InvoiceDtoUpdate GetByIdAsync(int id);
        Task InsertAsync(InvoiceDtoCreate obj);
        Task UpdateAsync(InvoiceDtoUpdate obj);
        void Delete(int id);
    }
}
