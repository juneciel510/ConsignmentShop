using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public decimal Incoming { get; set; }

        public Vendor()
        {
            Commission = 0.5;
            Incoming= 0M;
        }
        public string Display
        {
            get
            {
                return string.Format("{0} {1}'s Incoming: {2}", FirstName, LastName, Incoming);
            }
        }
    }
}
