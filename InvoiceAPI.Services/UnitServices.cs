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
    public class UnitServices : IUnit
    {
        private readonly ApplicationDbContext _context;

        public UnitServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var model = _context.units.Find(id);
            _context.units.Remove(model);
            _context.SaveChanges();

        }


        public   IEnumerable<UnitDtoUpdate> GetAllAsync()
        {
            var models =
                 _context.units.Select(i => new UnitDtoUpdate {  Id= i.Id, Name = i.Name }).ToList();

            return models;
        }

        public   UnitDtoUpdate GetByIdAsync(int id)
        {
            var models =
                 _context.units.Where(x => x.Id == id)
               .Select(i => new UnitDtoUpdate { Id=i.Id,Name=i.Name }).FirstOrDefault();

            return models;
        }

        public Task InsertAsync(UnitDtoCreate obj)
        {
            var entity = UnitDtoCreate.ConvertToObj(obj);
            _context.units.Add(entity);
            _context.SaveChanges();

            return Task.CompletedTask;
        }


        public Task UpdateAsync(UnitDtoUpdate obj)
        {
            var entity = UnitDtoUpdate.ConvertToObj(obj);
            _context.units.Update(entity);
            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
