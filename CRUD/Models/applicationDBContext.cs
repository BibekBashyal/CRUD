using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class applicationDBContext:DbContext
    {
        public applicationDBContext(DbContextOptions<applicationDBContext>options):base(options)
        {

        }

       public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
         
        }
    }
}
