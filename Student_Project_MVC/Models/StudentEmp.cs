namespace Student_Project_MVC.Models
{
    public interface StudentEmp
    {
        Student GetStudent();
        IEnumerable<Student> GetAllStudents();

    }
}
