using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace StudentManagement.Validation
{
    
    public class ValidationFirstName :ValidationAttribute
    {
        
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {

            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return new ValidationResult("This field is required.");
            }

            string firstName = value.ToString().Trim();

            if (firstName.Length < 3)
            {
                return new ValidationResult("First Name must be between 3 and 15 characters");
            }

            if (firstName.Length > 15)
            {
                return new ValidationResult("First Name must be between 3 and 18 characters");
            }

            // Check if the name contains at least 3 alphabets
            if (!Regex.IsMatch(firstName, @"^[a-zA-Z ]{3,}$"))
            {
                return new ValidationResult("First Name must be between 3 and 18 characters");
            }

            return ValidationResult.Success;

        }
    }
}
