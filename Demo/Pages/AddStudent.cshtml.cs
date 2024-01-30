using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo.Pages
{
    public class AddStudentModel : PageModel
    {
        [BindProperty]
        public int ID { get; set; }
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]

        public string Gender { get; set; }
        [BindProperty]


        public int Age { get; set; }
        [BindProperty]
        public string Class { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]

        public Student NewStudent { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("/Index");
        }

        private void SaveStudent(Student student)
        {

        }
    }
}
