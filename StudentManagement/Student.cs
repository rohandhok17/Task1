using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace StudentManagement
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This Field is required")]
        [MinLength(3 ,ErrorMessage = "The FirstName field should have min 3 char and max 15 char")]
        

        [StringLength(15, ErrorMessage = "The FirstName field should have min 3 char and max 15 char")]
       
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This Field is required")]
        [MinLength(2, ErrorMessage = "The FirstName field should have min 2 char and max 18 char")]
        [StringLength(18, ErrorMessage = "The FirstName field should have min 2 char and max 18 char")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This Field is required")]


        public string Gender { get; set; }
        [Required(ErrorMessage = "This Field is required")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "This Field is required")]
        [Range(5, 99 ,ErrorMessage = "Age value should be between 5 to 99")]
        public int Age { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
    }
}
