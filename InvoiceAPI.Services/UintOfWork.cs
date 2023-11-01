using InvoiceAPI.DataAccess;
using InvoiceAPI.Models.Entities;
using InvoiceAPI.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoviceAPI.Services
{
    public class UintOfWork : IUintOfWork
    {
        private ApplicationDbContext _context;
        public UintOfWork(InvoiceServices inovcie, ApplicationDbContext context, ItemServices iTem, StoreServices storeServices, UnitServices unitServices)
        {
            IInovcie = inovcie;
            _context = context;
            Item = iTem;
            Store= storeServices;
            Unit = unitServices;

        }

        public IInovcie IInovcie { get; }

        public IItem Item { get; }
       public IStore Store { get; }
       public IUnit Unit { get; }

        //private bool disposed = false;

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!disposed)
        //    {
        //        if (disposing)
        //        {
        //            _context.Dispose();
        //        }
        //    }
        //    disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}


        //// Implement the finalizer to release unmanaged resources
        //~UintOfWork()
        //{
        //    Dispose(false);
        //}
    }
}
