using System.Collections.Generic;
using System.Linq;
namespace New_JS_Project

{
    public class StudentDetails
    {
        private readonly List<Student> newstudents;

        public StudentDetails()
        {
           newstudents = new List<Student>
            {
                new Student{ID=1,FirstName="Ashish",LastName="Padole",Gender="Male",DateOfBirth = new DateTime(1990, 1, 1),Age=32,Class="11th",Address="Wardha"},
                new Student{ID=2,FirstName="Rani",LastName="Mahure",Gender="Female",DateOfBirth=new DateTime(1995,1,10),Age=26,Class="BSC",Address="Nagpur"}
            };
        }
        public List<Student>GetStudents()
        {
            return newstudents.ToList();
        }
        public Student GetStudentByID(int id)
        {
            return newstudents.FirstOrDefault(s => s.ID == id);
        }
        public void AddStudentOrUpdate(Student st) 
        {
            if(st.ID == 0) 
            {
                st.ID = newstudents.Count + 1;
                newstudents.Add(st);
            }
            else
            {
                var existingUsers = newstudents.FirstOrDefault(a=>a.ID == st.ID);
                if(existingUsers != null)
                {
                    existingUsers.FirstName= st.FirstName;
                    existingUsers.LastName= st.LastName;
                    existingUsers.Gender= st.Gender;
                    existingUsers.DateOfBirth= st.DateOfBirth;
                    existingUsers.Age = st.Age;
                    existingUsers.Class = st.Class;
                    existingUsers.Address = st.Address;
                }
            }
        }
        public void DeleteStudent(int id)
        {
            var DeleteStudent=newstudents.FirstOrDefault(s=>s.ID == id);
            if (DeleteStudent != null)
            {
                newstudents.Remove(DeleteStudent);
            }
        }
       
    }
}
