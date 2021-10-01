using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
public sealed class Customer
    {

        public int Custid { get; set; }
        public string Custname { get; set; }
    }

    public class Bank
    {
        Customer c = new Customer();

        public Bank()
        {
           
            Console.WriteLine("enter customer id");
            c.Custid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            c.Custname = Console.ReadLine();

        }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine("customer details");
            Console.WriteLine(c.Custid);
            Console.WriteLine(c.Custname);
        }


    }
}
