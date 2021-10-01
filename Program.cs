using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace AbstractInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Model = "LXI";
            c.Name = "Xeta";
            c.RegNo = "234234dd";
            c.Vehno = "KARNATAKA";
            c.Type = "Geared";
            Console.WriteLine(c.NoOfDoors);
            Console.WriteLine("Your Veh no =" + c.Vehno);
            Console.WriteLine("----------------------------------");
            TwoWheeler tw = new TwoWheeler();
            tw.Model = "HT";
            tw.Name = "Jupiter";
            tw.RegNo = "234234sdf";
            tw.Vehno = "MAHA";
            Console.WriteLine("Your Vehicle No=" + tw.Vehno);

            Console.WriteLine("--------------------------");

            Customer customer = new Customer();
            customer.Custid = 100;
            customer.Custname = "Jack";
            Console.WriteLine("------------------");

            Bank b = new Bank();
            b.DisplayCustomerDetails();


            Console.Read();
        }
    }
}
