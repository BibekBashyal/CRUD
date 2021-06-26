using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
              new Student
              {
                  Id = 2,
                  Name = "Bibek",
                  Department = "BE",
                  Email = "bibe@gmail.com"
              },
               new Student
               {
                   Id = 3,
                   Name = "Binod",
                   Department = "Bl",
                   Email = "bin@gmail.com"
               },
                new Student
                {
                    Id = 4,
                    Name = "Birat",
                    Department = "Bl",
                    Email = "btn@gmail.com"
                }


              );
        }
    }
}
