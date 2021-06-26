using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class SQLRepository:IStudentRepository
    {
        private readonly applicationDBContext context;

        public SQLRepository(applicationDBContext context)
        {
            this.context = context;
        }

        public Student Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }

        public Student Delete(int Id)
        {
            Student student = context.Students.Find(Id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
            return student;
        }

        public IEnumerable<Student> GetAllStudent()
        {
            return context.Students;
        }

        public Student GetStudent(int Id)
        {
            return context.Students.Find(Id);
        }

        public Student Update(Student studentChanges)
        {
            var employee = context.Students.Attach(studentChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return studentChanges;
        }
    }
}
