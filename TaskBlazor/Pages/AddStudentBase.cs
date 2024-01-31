using Microsoft.AspNetCore.Components;
using StudentManagement;
using System.Diagnostics.Contracts;

namespace TaskBlazor.Pages
{
    public  class AddStudentBase : ComponentBase
    {
        public List<Student> students = new()
        {
           new Student { Id = 1,FirstName="Rohan",LastName="Dhok",Gender="Male",DateOfBirth=new DateTime(2000,4,4),Age=34,Class="12th",Address="Wardha" },
               new Student { Id = 1,FirstName="Rahul",LastName="Guru",Gender="Male",DateOfBirth=new DateTime(1995,5,10),Age=25,Class="10th",Address="Wardha" }

        };

       public Student student = new()
        {
             
        };
       public void HandleSubmit()
        {
            StudentService.AddStudent(student);
            
        }
            
    }
}
