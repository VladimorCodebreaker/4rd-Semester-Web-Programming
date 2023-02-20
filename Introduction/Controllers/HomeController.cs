using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Introduction.Models;
using Introduction.Services;

namespace Introduction.Controllers
{
    public class HomeController : Controller // Client
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IStudentService studentService;

        public HomeController(ILogger<HomeController> logger, IStudentService studentService)
        {
            _logger = logger;
            this.studentService = studentService;
        }

        public IActionResult Index()
        {
            List<StudentViewModel> students = new List<StudentViewModel>();

            students.Add(new StudentViewModel { FirstName = "Jannick", LastName = "Müller", StudentNumber = "249802" });
            students.Add(new StudentViewModel { FirstName = "Patrick", LastName = "Müller", StudentNumber = "09124" });
            students.Add(new StudentViewModel { FirstName = "Janine", LastName = "Müller", StudentNumber = "82934" });
            students.Add(new StudentViewModel { FirstName = "Sarah", LastName = "Müller", StudentNumber = "09435" });
            students.Add(new StudentViewModel { FirstName = "Lala", LastName = "Müller", StudentNumber = "2903" });

            IndexViewModel viewModel = new IndexViewModel();
            viewModel.Group1 = students;
            viewModel.Group2.Add(new StudentViewModel { FirstName = "Thomas", LastName = "Icke", StudentNumber = studentService.GetStudentNumber().ToString() });



            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

