using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp2
{
    class ProductApp
    {
        static void Main(string[] args)
        {
            Products p = new Products();
            p.ProductID = 1;
            p.ProductName = "Mouse";
            p.ProductPrice = 700;
            p.Qty = 11;
            
            Console.WriteLine("Invoie Amt=" + p.InvAmt);
            Console.WriteLine("Discount= " + p.Discount);
            Console.Read();
           
        }
    }
}
