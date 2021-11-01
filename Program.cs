using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsumeWebServiceDemo.ServiceReference1;
namespace ConsumeWebServiceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient proxy = new WebService1SoapClient();
            Employee[] employees=proxy.ShowRecords("SPD","northwind","employees","", "");
            foreach (var item in employees)
            {
                Console.WriteLine(item.Empid);
                Console.WriteLine(item.Empname);
            }
            Console.Read();
        }
    }
}
