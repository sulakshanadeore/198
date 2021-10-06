using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionHandlingDemo;
namespace ConsoleApp1
{
    class MoreDetailsOfException
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter no1");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter no2");
                int j = Convert.ToInt32(Console.ReadLine());


                Demo d = new Demo();
                d.divide(i, j);
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("Message = " + ex.Message);
                Console.WriteLine("Inner Exception =" + ex.InnerException);
                Console.WriteLine("Source= " + ex.Source);
                Console.WriteLine("Stack Trace= " + ex.StackTrace);
                Console.WriteLine("Target Site= " + ex.TargetSite);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Message = " + ex.Message);
                Console.WriteLine("Inner Exception =" + ex.InnerException);
                Console.WriteLine("Source= " + ex.Source);
                Console.WriteLine("Stack Trace= " + ex.StackTrace);
                Console.WriteLine("Target Site= " + ex.TargetSite);

            }

            Console.Read();
        }
    }
}
