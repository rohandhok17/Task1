using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Validation
{
    public class ValidationAge :ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
      
            if (value == null)
            {
              
                return new ValidationResult("Age is required.");
            }

            if (value is not int age)
            {
               
                return new ValidationResult("Invalid age format.");
            }

            if (age < 5 || age > 99)
            {
             
                return new ValidationResult("Age must be between 5 and 99.");
            }

            
            return ValidationResult.Success;
        }
    }
}
