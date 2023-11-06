using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<string> Students = new List<string>();

            Students.Add("Rakesh");
            Students.Add("John");
            Students.Add("Bruce");

            ViewData["students"]= Students;


            return View();
        }
        public IActionResult Student()
        {
            Student student = new() { name = "John" , age=61};
            return View(student);
        }
    }
}
