using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Taskweb2.Models;

namespace Taskweb2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public UserData UserData { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            // Process the submitted form data
            // For simplicity, let's just print it to the console

            System.Console.WriteLine($"First Name: {UserData.FirstName}");
            // Repeat for other fields

            // You can save the data to a database or perform any other necessary actions here

            // Redirect to the confirmation page
            return RedirectToPage("/Confirmation");
        }
    }
}
