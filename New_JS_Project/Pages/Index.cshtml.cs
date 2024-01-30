using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace New_JS_Project.Pages
{
    public class IndexModel : PageModel
    {

        public List<Student> studentList { get; set; }
        private readonly StudentService students;

     
       
        public IndexModel(StudentService studentDetails) 
        {
            students = studentDetails;
        }
        public void OnGet()
        {
        studentList = students.ge``
        
        }
        public void OnPost() { 
        
        }
    }
}

