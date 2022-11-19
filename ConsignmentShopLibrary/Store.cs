using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Store
    {
        public string Name { get; set; }
        public decimal Incoming { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<Item> Items { get; set; }
        public Store()
        {
            Vendors=new List<Vendor>();
            Items=new List<Item>();
            Incoming = 0M;
        }
        public string Display
        {
            get
            {
                return string.Format("{0}'s Incoming: {1}", Name, Incoming);
            }
        }
    }
}
