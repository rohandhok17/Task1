namespace Task4
{


    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string sClass { get; set; }
        public string Address { get; set; }
        public class StudentService
        {
            public List<Student> GetStudents()
            {
                return new List<Student>
                {
                    new Student { FirstName = "Rahul", LastName = "Guri", Gender = "Male", Age = 23, sClass = "12th" },
                   new Student { FirstName = "Shubham", LastName = "Guru", Gender = "Male", Age = 10, sClass = "7th Class" }
                };
            }
        }
    }
} 
