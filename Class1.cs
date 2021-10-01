using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerid,string customername,string customerCity)
        {
            this.Custid = customerid;
            this.Custname = customername;
            this.City = customerCity;
        }
        public int Custid { get; set; }
        public string Custname { get; set; }
        public string City { get; set; }
    }
}
