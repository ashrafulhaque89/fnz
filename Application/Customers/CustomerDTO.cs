using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Customers
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public int Age { get {return calculateAge(DOB);} }
        
        public int calculateAge(DateTime DOB)
        {
            int age = 0;  
            age = DateTime.Now.Subtract(DOB).Days;  
            age = age / 365;  
            return age; 
        }
    }
}