using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webapp.Models;
using webapp.Repository;

namespace webapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }
          public List<Students> getAllstudent()
        {
            return _studentRepository.getAllstudent();
        }
        public Students GetStudentByid(int id)
        {
            return _studentRepository.getStudentByid(id);
        }
        public IActionResult Index()
        {
            //Students Student = new Students()
            //{
            //    rollNumber = 1,
            //    name = "Farhan",
            //    age = 25,
            //    grade = "Matric"
            //};

        //    var student = new List<Students>()
        //    {
        //        new Students{rollNumber=1, name="Rizwan", age=15,grade ="Matric"},
        //        new Students{rollNumber=2, name="Ayesha", age=22,grade ="Master"},
        //        new Students{rollNumber=3, name="Ali", age = 25, grade = "Matric"},
        //        new Students{rollNumber=4, name="Khansa", age = 12, grade="BA"},
        //        new Students{rollNumber=5, name="Wajahat",age = 33, grade="Inter"}
        //    };
        //ViewData["std"]= student;
            return View();
            //return View(Student);
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