using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppStudent.Models
{
    internal class StudentService
    {
        private static  List<Student> students = new List<Student>()
        {
           new Student { Id = 1,FirstName="Rohan",LastName="Dhok",Gender="Male",DateOfBirth=new DateTime(2000,4,4),Age=34,Class="12th",Address="Wardha" },
               new Student { Id = 2,FirstName="Rahul",LastName="Guru",Gender="Male",DateOfBirth=new DateTime(1995,5,10),Age=25,Class="10th",Address="Wardha" }

        };
        public static List<Student> GetStudents()
        {
            return students;
        }


        public static void AddStudent(Student student)
        {
            student.Id = students.Max(student => student.Id) + 1;
            students.Add(student);
        }
        public static Student GetStudent(int id)
        {
            return students.Find(Student => Student.Id == id);
        }

        public static void UpdateStudent(Student updateStudent)
        {

            Student exitingStudent = GetStudent(updateStudent.Id);
            exitingStudent.FirstName = updateStudent.FirstName.Trim();
            exitingStudent.LastName = updateStudent.LastName.Trim();
            exitingStudent.Gender = updateStudent.Gender;
            exitingStudent.Age = updateStudent.Age;
            exitingStudent.DateOfBirth = updateStudent.DateOfBirth;
            exitingStudent.Class = updateStudent.Class.Trim();
            exitingStudent.Address = updateStudent.Address.Trim();
        }

        public static void DeleteStudent(int id)
        {
            Student std = GetStudent(id);
            students.Remove(std);
        }

    }
}
