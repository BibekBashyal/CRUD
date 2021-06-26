using CRUD.Models;
using CRUD.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
        private IStudentRepository _studentrepo;

        public HomeController(IStudentRepository studentRepo)
        {
            _studentrepo = studentRepo;
        }

        public ViewResult Index()
        {
            StudentViewModel svm = new StudentViewModel() {
            Student = _studentrepo.GetStudent(1)
        };
            return View(svm);
        }

        // Rest of the code
    }
}
