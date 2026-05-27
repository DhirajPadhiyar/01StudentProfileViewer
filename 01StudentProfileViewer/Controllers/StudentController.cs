using Microsoft.AspNetCore.Mvc;
using _01StudentProfileViewer.Models;

namespace _01StudentProfileViewer.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student()
            {
                Name = "Dhiraj Padhiyar",
                Age = 30,
                City = "Dubai",
                Course = "ASP.NET Core MVC"
            };

            Student student1 = new Student()
            {
                Name = "Ravi Padhiyar",
                Age = 32,
                City = "New York City",
                Course = "OPTIONS TRADING"
            };
            List<Student> students = new List<Student>()
            {
                 student,
                 student1
            };

            return View(students);
        }
    }
}
