using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentManagement.Validation
{
    public class ValidatiionLastName : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return new ValidationResult("This field is required.");
            }

            string lastName = value.ToString().Trim();

            if (lastName.Length < 2)
            {
                return new ValidationResult("Last Name must be between 2 and 18 characters");
            }

            if (lastName.Length > 18)
            {
                return new ValidationResult("Last Name must be between 3 and 18 characters");
            }

            // Check if the name contains at least 3 alphabets
            if (!Regex.IsMatch(lastName, @"^[a-zA-Z ]{2,}$"))
            {
                return new ValidationResult("Last Name must be between 3 and 18 characters");
            }

            return ValidationResult.Success;
        }
    }
}
