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
    public class ItemServices : IItem
    {
        private readonly ApplicationDbContext _context;

        public ItemServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var model = _context.Items.Find(id);
           

     
            _context.Items.Remove(model);
            _context.SaveChanges();
        }

        

       

        public IEnumerable<ItemDtoUpdate> GetAllAsync()
        {
            var models =
                 _context.Items
               .Select(i => new ItemDtoUpdate 
               {
                   Id = i.Id, 
                   Name = i.Name,
                
               })
               .ToList();

            return models;
        }

        public ItemDtoUpdate GetByIdAsync(int id)
        {
            var models =
               
                _context.Items.Where(x => x.Id == id)
               .Select(i => new ItemDtoUpdate {  Id = i.Id,Name=i.Name }).FirstOrDefault();

            return models;
        }

        public Task InsertAsync(ItemDtoCreate obj)
        {
            var entity = ItemDtoCreate.ConvertToObj(obj);
            _context.Items.AddAsync(entity);
            _context.SaveChanges();

            return Task.CompletedTask;
        }

    
        public Task UpdateAsync(ItemDtoUpdate obj)
        {
            var entity = ItemDtoUpdate.ConvertToObj(obj);
            _context.Items.Update(entity);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

    }
}
