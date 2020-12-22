using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignSolution
{
    class Customers
    {
        public int Customers_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public int Current_Age { get { return CalculateAge(DOB); }}

        public int CalculateAge(DateTime DOB)
        {
            return DateTime.Now.Subtract(DOB).Days / 365;
        }
    }
}
