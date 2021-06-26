using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
 
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _studentList;

        public StudentRepository()
        {
            _studentList = new List<Student>()
        {
            new Student() { Id = 1, Name = "Mary", Department = "Science", Email = "mary@pragimtech.com" },
            new Student() { Id = 2, Name = "John", Department = "IT", Email = "john@pragimtech.com" },
            new Student() { Id = 3, Name = "Sam", Department = "Management", Email = "sam@pragimtech.com" },
        };
        }

        public Student Add(Student stud)
        {
            stud.Id = _studentList.Max(e => e.Id) + 1;
            _studentList.Add(stud);
            return stud;
        }

        public Student Delete(int Id)
        {
            Student stud = _studentList.FirstOrDefault(e => e.Id == Id);
            if (stud != null)
            {
                _studentList.Remove(stud);
            }
            return stud;
        }

        public IEnumerable<Student> GetAllStudent()
        {
            return _studentList;
        }

        public Student GetStudent(int Id)
        {
            return this._studentList.FirstOrDefault(e => e.Id == Id);
        }

        public Student Update(Student studentChanges)
        {
            Student student = _studentList.FirstOrDefault(e => e.Id == studentChanges.Id);
            if (student != null)
            {
                student.Name = studentChanges.Name;
                student.Email = studentChanges.Email;
                student.Department = studentChanges.Department;
            }
            return student;
        }
    }
}
