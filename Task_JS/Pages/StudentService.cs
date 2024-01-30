namespace Task_JS.Pages
{
    public class StudentService
    {
        private readonly List<Student> student_s;

        public StudentService()
        {
            student_s = new List<Student>
            {
                new Student {ID = 1, FirstName = "Manish", LastName = "Padole", Gender = "Male", DateOfBirth = new DateTime(1990, 1, 1), Age = 32, Class = "10th", Address = "Wardha" },
                new Student {ID = 1, FirstName = "Rahul", LastName = "Raj", Gender = "Male", DateOfBirth = new DateTime(1990, 1, 1), Age = 32, Class = "10th", Address = "Wardha" },

            };
        }
        public List<Student> GetStudents()
        {
            return student_s.ToList();
        }
        public Student GetStudentById(int id)
        {
            return student_s.FirstOrDefault(s => s.ID == id);
        }
        public void AddOrUpdateStudent(Student student)
        {
            if (student.ID == 0)
            {
                student.ID = student_s.Count + 1;
                student_s.Add(student);
            }
            else
            {
                var existingStudent = student_s.FirstOrDefault(s => s.ID == student.ID);
                if (existingStudent != null)
                {
                    TrimStudentData(student);
                    existingStudent.FirstName = student.FirstName;
                    existingStudent.LastName = student.LastName;
                    existingStudent.Gender = student.Gender;
                    existingStudent.DateOfBirth = student.DateOfBirth;
                    existingStudent.Age = student.Age;
                    existingStudent.Class = student.Class;
                    existingStudent.Address = student.Address;
                    // Update other properties as needed
                }
            }
        }
        public void DeleteStudent(int id)
        {
            var studentToDelete = student_s.FirstOrDefault(s => s.ID == id);
            if (studentToDelete != null)
            {
                student_s.Remove(studentToDelete);
            }
        }
        private void TrimStudentData(Student student)
        {

            student.FirstName = student.FirstName?.Trim();
            student.LastName = student.LastName?.Trim();
            student.Gender = student.Gender?.Trim();
            student.Class = student.Class?.Trim();
            student.Address = student.Address?.Trim();

        }

    }
}
