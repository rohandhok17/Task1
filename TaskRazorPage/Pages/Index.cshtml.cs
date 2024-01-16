using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskRazorPage.NewFolder;

namespace TaskRazorPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public string UserName {  get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public bool IsError {  get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            var uname = UserName;
            var pass = Password;

            var employee = Data.Employees.FirstOrDefault(x=>x.UserName == uname && x.Password == pass);
            if (employee != null)
            {
                return RedirectToPage("EmployeeDashboard", new { employeeID = employee.EmployeeId });
            }
            else
            {
                IsError = true;
                return Page();
            }
            
        }
    }
}
