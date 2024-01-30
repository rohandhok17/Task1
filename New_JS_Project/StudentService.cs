
namespace New_JS_Project
{
    public class StudentService
    {
        private readonly StudentService studentService;

        public StudentService(StudentService studentService)
        {
            studentService = new List<Student>
            {

                 new Student { ID = 1, FirstName = "Rohan", LastName = "Dhok", Gender = "Male", DateOfBirth = new DateTime(1990, 1, 1), Age = 32, Class = "10th", Address = "Wardha" },
            new Student { ID = 2, FirstName = "Ratnadeep", LastName = "Pawar", Gender = "Male", DateOfBirth = new DateTime(1992, 5, 15), Age = 30, Class = "12th", Address = "Solapur" },


            };
        }

       
    }

}
