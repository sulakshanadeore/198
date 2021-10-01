using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace CollectionsDemo
{
    class GenericsDemo
    {
        static void Main(string[] args)
        {
            //Type casting overhead is saved
            //List<int> li = new List<int>(); 
            //li.Add(12);
            //li.Add(243);
            //foreach (var item in li)
            //{
            //    Console.WriteLine(item);
            //}


            List<Customer> custlist = new List<Customer>();
            Console.WriteLine("How many customer u need to add");
            int count=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= count-1; i++)
            {
                Customer c = new Customer();
                Console.WriteLine("Enter customer id");
                c.Custid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter customer name");
                c.Custname = Console.ReadLine();
                Console.WriteLine("Enter Customer city");
                c.City = Console.ReadLine();
                custlist.Add(c);
            }
            

            
            //custlist.Add(new Customer {Custid=2,Custname="RAJ",City="Pune" });
            //custlist.Add(new Customer(3, "JAI", "DELHI"));


            foreach (var item in custlist)
            {
                Console.WriteLine(item.Custid);
                Console.WriteLine(item.Custname);
                Console.WriteLine(item.City);
            }

            Console.Read();

        }
    }
}
