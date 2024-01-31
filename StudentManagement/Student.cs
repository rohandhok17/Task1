using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace StudentManagement
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        

        [StringLength(15)]
       
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        [StringLength(18)]
        public string LastName { get; set; }
        [Required]
        

        public string Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Range(5, 99)]
        public int Age { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
    }
}
