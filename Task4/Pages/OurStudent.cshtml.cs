using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Task4.Pages
{
    public class OurStudentModel : PageModel
    {
        [BindProperty]
        public StudentModel Student { get; set; }

        public List<StudentModel> SavedStudents { get; set; } = new List<StudentModel>();

        public void OnGet()
        {
            // Initialize the Student property if needed
        }

        public IActionResult OnPost(string submitButton)
        {
            // Check which button was clicked
            if (submitButton == "Save")
            {
                // Validate the model
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                // Save the data
                SavedStudents.Add(new StudentModel
                {
                    FirstName = Student.FirstName,
                    LastName = Student.LastName
                });

                // Clear the input fields
                Student.FirstName = string.Empty;
                Student.LastName = string.Empty;
            }

            return Page();
        }
    }

    public class StudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}

