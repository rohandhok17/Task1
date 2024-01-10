using Microsoft.AspNetCore.Mvc;

namespace Task2.Controllers
{
    public class AddStudent : Controller
    {
        [Route("yourController/your-action")]
        public IActionResult Addstudent( )
        {
            return View();
        }
    }
}
