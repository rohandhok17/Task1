using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStudent
{
    public class StudentService
    {
        private static  List<Student> students = new()
        {
           new Student { Id = 1,FirstName="Rohan",LastName="Dhok",Gender="Male",DateOfBirth=new DateTime(2000,4,4),Age=34,Class="12th",Address="Wardha" },
               new Student { Id = 2,FirstName="Rahul",LastName="Guru",Gender="Male",DateOfBirth=new DateTime(1995,5,10),Age=25,Class="10th",Address="Wardha" }

        };
        public static List<Student> GetStudentsAll()
        {
            return students;
        }
        //public static List<Student> GetStudentsAll() => students;

        public static void AddStudent(Student student)
        {
            Student StTrim = new()
            {
                FirstName = student.FirstName.Trim(),
                LastName = student.LastName.Trim(),
                Gender = student.Gender.Trim(),
                DateOfBirth = student.DateOfBirth,
                Age = student.Age,
                Class = student.Class.Trim(),
                Address = student.Address.Trim(),
            };
            students.Add(StTrim);
        }
        public static Student GetStudent(int id)
        {
            return students.Find(Student => Student.Id == id);
        }

        public static void UpdateStudent(Student updateStudent)
        {

            Student exitingStudent = GetStudent(updateStudent.Id);
            exitingStudent.FirstName = updateStudent.FirstName;
            exitingStudent.LastName = updateStudent.LastName;
            exitingStudent.Gender = updateStudent.Gender;
            exitingStudent.Age = updateStudent.Age;
            exitingStudent.DateOfBirth = updateStudent.DateOfBirth;
            exitingStudent.Class = updateStudent.Class;
            exitingStudent.Address = updateStudent.Address;
        }

        public static void DeleteStudent(int id)
        {
            Student std = GetStudent(id);
            students.Remove(std);
        }
    }
}
