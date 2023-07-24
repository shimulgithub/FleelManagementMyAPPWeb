using Microsoft.EntityFrameworkCore.Diagnostics;
using MyApp.DataAccesslayer;
using MyApp.DataAccessLayer.Infrustructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataAccessLayer.Infrustructure.Repository
{
    public class UnitofWork : IUnitofWork
    {
        private ApplicationDbContext _context;
        public ICategoryRepository Category { get; private set; }
        public UnitofWork(ApplicationDbContext context)
        {
            _context = context;
            Category = new CategoryRepository(context);
        }    
        public  void Save()
        {
            _context.SaveChanges();
        }
    }
}
