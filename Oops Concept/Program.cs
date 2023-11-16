using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    class program
    {
        static void Main(string[] args)
        {
            order order = new order();
            order.Orderno = "123";
            order.Ordervalue = "1000";
            order.Ordercountry = "India";

            order.createorder();


            Student student = new Student();
            student.FirstName = "firstname";
            student.LastName = "lastname";
            student.studentAddress = "demo address";
            student.getdetails();


        }
    }
}
