using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    public class Details
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string getdetails()
        {
            return "FirstName is" + FirstName + "LastName is " + LastName; 
        }
    }
    public class Student : Details
    {
        public string studentAddress { get; set; }
    }

    public class Teacher : Details
    {
        public string subject { get; set; }
    }
}
