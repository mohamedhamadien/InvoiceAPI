﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceAPI.Models.Entities;

namespace InvoiceAPI.Models.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
       Task<IEnumerable<T>>GetAllAsync();
        Task<T> GetByIdAsync(int id);
    //    Task InsertAsync(T obj);
      //  Task UpdateAsync(T obj);
        Task DeleteAsync(int id);
        Task<bool> SaveAsync();
    }
}
