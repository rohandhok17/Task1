using StudentManagement.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStudent
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This Filed is required"), RegularExpression(@"^(?=(?:.*[^\s]){3})\s*\S(?:\s*\S){2,}\s*$", ErrorMessage = "FirstName must be between 3 and 15 letters"),]


        public string FirstName { get; set; }


        [Required(ErrorMessage = "This Filed is required"), RegularExpression(@"^\s*\S(.|\s)*\S\s*$", ErrorMessage = "FirstName must be between 2 and 18 letters"),]

        public string LastName { get; set; }


        [Required(ErrorMessage = "This Field is required")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "This Field is required")]

        [ValidationDateOfBirth(ErrorMessage = "This Field is required")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "This Field is required")]
        [Range(5, 99, ErrorMessage = "Age must be between 5 and 99")]
        [RegularExpression(@"^\d{2}$", ErrorMessage = "Age must be between 5 and 99")]
        public int? Age { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
    }
}
