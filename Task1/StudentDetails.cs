using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    public  class StudentDetails
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                   
                }
                if (value.Length < 3 || value.Length > 15)
                {

                }
                firstName = value;
            }
        }
                  
        public string LastName { get; set; }
        public string Gender {  get; set; } 
        public DateTime DateOfBirth { get; set; }
        public int Age {  get; set; }   
        public string Class {  get; set; }  
        public string Address {  get; set; }    
    }
}
