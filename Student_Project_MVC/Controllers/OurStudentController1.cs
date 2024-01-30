using Microsoft.AspNetCore.Mvc;

namespace Student_Project_MVC.Controllers
{
    public class OurStudentController1 : Controller
    {
        private readonly ILogger<OurStudentController1> _logger;

        public OurStudentController1(ILogger<OurStudentController1> logger)
        {
            _logger = logger;
        }

        [ActionName("AddStudent")]
        public IActionResult AddStudent(string firstName)
        {
            return Content("Good Morning, " + firstName + "");
        }
        public IActionResult EditStudent()
        {
            return View();
        }
    }
}
