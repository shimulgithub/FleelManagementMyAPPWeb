using System;

using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.DataAccesslayer
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        { }
        public DbSet<Category> Categories { get; set; }

    }

   
}
