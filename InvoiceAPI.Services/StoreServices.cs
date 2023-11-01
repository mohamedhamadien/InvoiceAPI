using InvoiceAPI.DataAccess;
using InvoiceAPI.Models.Dtos;
using InvoiceAPI.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoviceAPI.Services
{
    public class StoreServices : IStore
    {
        private readonly ApplicationDbContext _context;

        public StoreServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var model = _context.Stores.Find(id);
            _context.Stores.Remove(model);
            _context.SaveChanges();

        }


        public   IEnumerable<StoreDtoUpdate> GetAllAsync()
        {
            var models =
                 _context.Stores.Select(i => new StoreDtoUpdate { Id =i.Id,Name = i.Name }).ToList();

            return models;
        }

        public StoreDtoUpdate GetByIdAsync(int id)
        {
            var models =
                 _context.Stores.Where(x => x.Id == id)
               .Select(i => new StoreDtoUpdate { Id = i.Id, Name = i.Name }).FirstOrDefault();

            return models;
        }

        public Task InsertAsync(StoreDtoCreate obj)
        {
            var entity = StoreDtoCreate.ConvertToObj(obj);
            _context.Stores.Add(entity);
            _context.SaveChanges();

            return Task.CompletedTask;
        }


        public Task UpdateAsync(StoreDtoUpdate obj)
        {
            var entity = StoreDtoUpdate.ConvertToObj(obj);
            _context.Stores.Update(entity);
            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
