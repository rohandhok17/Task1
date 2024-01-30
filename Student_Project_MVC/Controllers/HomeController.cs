using Microsoft.AspNetCore.Mvc;
using Student_Project_MVC.Models;
using System;
using System.Diagnostics;

namespace Student_Project_MVC.Controllers
{
    public class HomeController : Controller
    {
        private IStudentRepository _studentRepository;
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public string Index()
        {
            // Ensure _studentRepository is not null before using it
            if (_studentRepository != null)
            {
                var student = _studentRepository.GetStudent(1);

                // Ensure the returned student is not null before accessing properties
                if (student != null)
                {
                    return student.FirstName;
                }
                else
                {
                    return "Student not found";
                }
            }
            else
            {
                // Log or handle the case where _studentRepository is null
                return "Student repository not available";
            }




        }
    }
}
