using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using StudentManagement.Validation;
namespace StudentManagement
{
    public class Student
    {

        // Lables
        public const string FirstNameLbl = "First Name";
        public const string LastNameLbl = "Last Name";
        public const string GenderLbl = "Gender";
        public const string DOBLbl = "Date Of Birth";
        public const string AgeLbl = "Age";
        public const string ClassLbl = "Class";
        public const string AddressLbl = "Address";
        public const string Yeartxt = " years";

        //Errors
        public const string MainError = "This field is required";
        public const string FirstNameLengthError = "First Name must be between 3 and 15 letters";
        public const string LastNameLengthError = "Last Name must be between 2 and 18 letters";
        public const string AgeLimitError = "Age must be between 5 and 99.";



        //Heading / Lables
        public const string OurStdLbl = "Our Students";
        public const string AddStdLbl = "Add Student";
        public const string EditStdLbl = "Edit Student";

        //Buttons
        public const string AddBtnTxt = "+ Add";
        public const string SaveBtnTxt = "Save";
        public const string DeleteBtnTxt = "Delete";
        public const string CancelBtnTxt = "Cancel";

        //Delete Confirmation 
        public const string DeleteStdCfm = "Are you sure you want to delete this student record?";

        //Placeholders
        public const string SearchPlacehr = "Search...";
        public const string FirstNamePlacehr = "Please Enter Your First Name";
        public const string LastNamePlacehr = "Please Enter Your Last Name";
        public const string GenderPlacehr = "Please Select Gender";
        public const string AgePlacehr = "Please Enter Your Age";
        public const string ClassPlacehr = "Please Enter Your Class";
        public const string AddressPlacehr = "Please Enter Your Address";
        public int Id { get; set; }
      
        [Required(ErrorMessage ="This Filed is required"), RegularExpression(@"^(?=(?:.*[^\s]){3})\s*\S(?:\s*\S){2,}\s*$", ErrorMessage = "FirstName must be between 3 and 15 letters"),]


        public string FirstName { get; set; }
      
      
        [Required(ErrorMessage = "This Filed is required"), RegularExpression(@"^\s*\S(.|\s)*\S\s*$", ErrorMessage = "FirstName must be between 2 and 18 letters"),]

        public string LastName { get; set; }
      

        [Required(ErrorMessage = "This Field is required")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "This Field is required")]
        
        [ValidationDateOfBirth(ErrorMessage ="This Field is required")]
        public DateTime? DateOfBirth { get; set; }
       
        [Required(ErrorMessage = "This Field is required")]
        [Range(5, 99, ErrorMessage = "Age must be between 5 and 99")]
        [RegularExpression(@"^\d{2}$", ErrorMessage = "Age must be between 5 and 99")]
        public int? Age { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
    }
}
