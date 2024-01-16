using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskRazorPage.NewFolder;

namespace TaskRazorPage.Pages
{
    public class EmployeeDashboardModel1 : PageModel
    {
        public Employee Employee { get; set; }
        [BindProperty(Name ="employeeId",SupportsGet = true)]
        public int EmployeeId {  get; set; }
        
        
        
        public void OnGet()
        {
            var emId = EmployeeId;
            Employee = Data.Employees.FirstOrDefault(x => x.EmployeeId == emId);
        }
    }
}
