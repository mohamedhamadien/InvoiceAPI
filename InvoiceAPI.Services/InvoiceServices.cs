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
    public class InvoiceServices : IInovcie
    {
        private readonly ApplicationDbContext _context;

        public InvoiceServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var model =  _context.Invoices.Find(id);
            _context.Invoices.Remove(model);
             _context.SaveChanges();
            
        }


        public IEnumerable<InvoiceDtoUpdate> GetAllAsync()
        {
            var models = 
                 _context.Invoices.Select(i => new InvoiceDtoUpdate { Date = i.Date, Id = i.Id, Store = i.Store }).ToList();

            return  models;
        }

        public InvoiceDtoUpdate GetByIdAsync(int id)
        {
            var models =
                 _context.Invoices.Where(x => x.Id ==id)
               .Select(i => new InvoiceDtoUpdate { Date = i.Date, Id = i.Id, Store = i.Store }).FirstOrDefault();

            return models;
        }

        public Task InsertAsync(InvoiceDtoCreate obj)
        {
            var entity = InvoiceDtoCreate.ConvertToObj(obj);
            _context.Invoices.AddAsync(entity);
            _context.SaveChangesAsync();

            return Task.CompletedTask;
        }


        public Task UpdateAsync(InvoiceDtoUpdate obj)
        {
            var entity = InvoiceDtoUpdate.ConvertToObj(obj);
            _context.Invoices.Update(entity);
            _context.SaveChangesAsync();
            return Task.CompletedTask;
        }

       
    }
}
