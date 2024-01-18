using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Reflection;

namespace TaskRazorPage.NewFolder
{
    public class Data
    {
        public static List<Employee> Employees = new List<Employee>
        {
            
            new Employee {UserName="Rohan",Password="Rohan"},
            new Employee {UserName="Rohan",Password="Rohan"}
        };
    }
}
