using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo.Pages
{
    public class IndexModel : PageModel
    {
        public List<Student> Students { get; set; } 
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Students = GetUserListFromDataSource();
        }
        private List<Student> GetUserListFromDataSource()
        {
            // Implement your logic to fetch users from the data source (e.g., a database)
            // For demonstration purposes, a dummy list is returned here.
            return new List<Student>
        {
            new Student { ID = 1, FirstName="Ram",LastName="Hari",Gender="Male",Age=12,Class="10th",Address="Wardha"},
             new Student { ID = 1, FirstName="raman",LastName="hole",Gender="Male",Age=12,Class="5th",Address="Wardha"},
            // Add more users as needed
        };
        }
    }
}
