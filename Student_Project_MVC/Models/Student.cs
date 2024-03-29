﻿using System.ComponentModel.DataAnnotations;

namespace Student_Project_MVC.Models
{
    public class Student
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender {  get; set; }

        public DateTime DateOfBirth{ get; set; }
        public int Age {  get; set; }
        public string Class {  get; set; }
        public string Address {  get; set; }
    }
}
