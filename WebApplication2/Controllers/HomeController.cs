using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DisplayData(ExpandoObject formData)
        {
            formData.TryAdd("FirstName", Request.Form["FirstName"]);
            formData.TryAdd("LastName", Request.Form["LastName"]);


            // Save the data to a database or wherever needed

            // Redirect to the display page with the entered data
            return RedirectToAction("DisplayPage", formData);
        }

        public ActionResult DisplayPage(dynamic person)
        {
            return View(person);
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
