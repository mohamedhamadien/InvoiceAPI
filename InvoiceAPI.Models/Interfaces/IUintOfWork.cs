using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPI.Models.Interfaces
{
    public interface IUintOfWork 
    {
        IInovcie IInovcie { get; }
        IItem Item { get; }
        IStore Store { get; }
        IUnit Unit { get; }
    }
}
