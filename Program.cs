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
            Console.WriteLine("Your Veh no =" + c.Vehno);
            Console.Read();
        }
    }
}
