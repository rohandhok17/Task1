using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Task2_Using_JS.Pages
{
    public class IndexModel : PageModel

    {
        private readonly Student_Class student_class;
        
        //private readonly ILogger<IndexModel> _logger;

        public IndexModel(Student_Class Student_c)
        {
            student_class = Student_c;
        }
        public List<Student> Students { get; set; }


        public void OnGet()
        {
            Students = student_class.GetStudents();
        }
    }
}
