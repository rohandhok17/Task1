using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Taskweb2.Pages.Shared
{
    public class ConfirmationModelModel : PageModel
    {
        [BindProperty]
        public UserData UserData { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
           
            return RedirectToPage("/Index");
        }
    }
}
