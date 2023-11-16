using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    public class order
    {
        public string Orderno { get; set; }
        public string Ordervalue { get; set; }
        public string Ordercountry { get; set; }

        public string createorder()  
        {
            return "Order Created";
        }

        public bool ValidateOrdervalue()
        {
            return true;
        }

        public bool ValidateOrdercountry()
        {
            return true;
        }


    }
}

