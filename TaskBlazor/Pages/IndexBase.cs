using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.Extensions;
using StudentManagement;


namespace TaskBlazor.Pages
{
    public class IndexBase : ComponentBase
    {
        //public List<Student>Students { get; set; }  
        public IEnumerable<Student> Students { get; set; }
        protected override Task OnInitializedAsync()
        {
            LoadStudent();
            return base.OnInitializedAsync();
        }
        
        private void LoadStudent()
        {
            Students = new List<Student>
            {
                new Student { Id = 1,FirstName="Rohan",LastName="Dhok",Gender="Male",DateOfBirth=new DateTime(2000,4,4),Age=34,Class="12th",Address="Wardha" },
                new Student { Id = 1,FirstName="Rahul",LastName="Guru",Gender="Male",DateOfBirth=new DateTime(1995,5,10),Age=25,Class="10th",Address="Wardha" }

            };
        }
        public List<Student> GetStudents()
        {
            return Students.ToList();
        }
        public static void AddStudent(Student student)
        {
           
        }

    }

}

