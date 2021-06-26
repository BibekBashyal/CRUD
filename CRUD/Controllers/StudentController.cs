using CRUD.Models;
using CRUD.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController

        private IStudentRepository _studentrepo;

        public StudentController(IStudentRepository studentRepo)
        {
            _studentrepo = studentRepo;
        }

        public ViewResult Index()
        {
            StudentViewModel svm = new StudentViewModel()
            {
                Student = _studentrepo.GetStudent(1)
            };
            return View(svm);
        }
    }
}

        

        