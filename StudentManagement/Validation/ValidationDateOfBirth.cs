using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ValidationDateOfBirth : ValidationAttribute
    {  public override bool IsValid(object value)
            {
                if (value is DateTime date)
                {
                    return date.Date != DateTime.Today;
                }

            return true;
            }
        }
    }

