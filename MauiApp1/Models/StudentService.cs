using MauiApp1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class StudentService
    {
        private static  List<Student> students = new()
        {
           new Student { Id = 1,FirstName="Rohan",LastName="Dhok",Gender="Male",DateOfBirth=new DateTime(2000,4,4),Age=34,Class="12th",Address="Wardha" },
               new Student { Id = 2,FirstName="Rahul",LastName="Guru",Gender="Male",DateOfBirth=new DateTime(1995,5,10),Age=25,Class="10th",Address="Wardha" }

        };
        //public static List<Student> GetStudentsAll()
        //{
        //    return students;
        //}
        public static List<Student> GetStudentsAll() => students;


        public static void AddStudent(Student student)
        {
            student.Id = students.Max(student => student.Id) + 1;
            students.Add(student);
            Shell.Current.GoToAsync($"{nameof(Ourstudent)}");
        }
        public static Student GetStudentBy(int id)
        {
            return students.Find(Student => Student.Id == id);
        }

        public static void UpdateStudent(Student updateStudent)
        {

            Student exitingStudent = GetStudentBy(updateStudent.Id);
            exitingStudent.FirstName = updateStudent.FirstName.Trim();
            exitingStudent.LastName = updateStudent.LastName.Trim();
            exitingStudent.Gender = updateStudent.Gender;
            exitingStudent.Age = updateStudent.Age;
            exitingStudent.DateOfBirth = updateStudent.DateOfBirth;
            exitingStudent.Class = updateStudent.Class.Trim();
            exitingStudent.Address = updateStudent.Address.Trim();
            Shell.Current.GoToAsync($"{nameof(Ourstudent)}");
        }

        public static void DeleteStudent(int id)
        {
            Student std = GetStudentBy(id);
            students.Remove(std);
        }
        public static List<Student>SearchStudent(string filter)
        {
            var studentSearch=students.Where(x=>!string.IsNullOrWhiteSpace(x.FirstName)&& x.FirstName.ToLower().Contains(filter.ToLower())).ToList();
            if(studentSearch==null|| studentSearch.Count <=0)
                studentSearch = students.Where(x => !string.IsNullOrWhiteSpace(x.LastName) && x.LastName.ToLower().Contains(filter.ToLower())).ToList() ;
            
            else return studentSearch;
            if (studentSearch == null || studentSearch.Count <= 0)
                studentSearch = students.Where(x =>  x.Age==int.Parse(filter)).ToList() ;
            return studentSearch;

        }
        public List<Student> StudentCollection
        {
            get { return students; }
            set { students = value; }

        }
    }
}
