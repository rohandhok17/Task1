
namespace Student_Project_MVC.Models
{
    public class MockStudent : IStudentRepository
    {
        private List<Student> _studentList;
        public MockStudent()
        {
            _studentList = new List<Student>
            {

                new Student() { FirstName = "Guru", LastName = "Dev", Gender = "Male", DateOfBirth = new DateTime(2000, 1, 20), Age = 24, Class = "8", Address = "Nagpur" }

            };
        }

        public IEnumerable<Student> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            return _studentList.FirstOrDefault(e => e.Id == id);
        }

    }
    
}
