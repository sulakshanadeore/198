using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionHandlingDemo;
namespace ConsoleApp1
{
    class Program
    {

        static void M1(Nullable<int> i, dynamic d1)
        {

        }
        static void Main(string[] args)
        {
            //Types which stored on  stack--are value types--struct/enums
            //int i = null;
            //Value types cannot be null, Reference types can be null
            // Nullable<int> i = null;//Nullable type
            //int? j = null;//Nullable type
            // Console.WriteLine(j.GetType());
            // Console.WriteLine("Get Type");
            // int k = 100;
            // Console.WriteLine(k.GetType());
            // Console.WriteLine("with var");
            // var y = "hello";// Implicitly typed variable
            // Console.WriteLine(y.GetType());
            // Console.WriteLine("With dynamic......");
            // dynamic f = "888";
            // Console.WriteLine(f.GetType());
            // f = 45435;
            // Console.WriteLine(f.GetType());           // Nullable<int> i = null;//Nullable type
            //int? j = null;//Nullable type
            // Console.WriteLine(j.GetType());
            // Console.WriteLine("Get Type");
            // int k = 100;
            // Console.WriteLine(k.GetType());
            // Console.WriteLine("with var");
            // var y = "hello";// Implicitly typed variable
            // Console.WriteLine(y.GetType());
            // Console.WriteLine("With dynamic......");
            // dynamic f = "888";
            // Console.WriteLine(f.GetType());
            // f = 45435;
            // Console.WriteLine(f.GetType());


            //Error----compile & runtime
            //Compile-syntax error
            //     Runtime -logic or exceptional cases related to logic

            Employee emp = new Employee();
            //Console.WriteLine("Enter Employee id");
            try
            {
                //may throw a exception
                //  emp.Empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number1");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number2");
                int n2 = Convert.ToInt32(Console.ReadLine());
                try
                {
                    int ans = n1 / n2;//Processing/logic
                    Console.WriteLine(ans);
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            Console.WriteLine("Thanks for your input");
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine(ex.Message);//Developer
                Console.WriteLine("Pls enter non zero positive denominator");//end user
            }
            catch (FormatException ex)
            {
                Console.WriteLine("I m in the format exception catch block");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("I m in the general exception catch block");

            }
            finally
            {
                Console.WriteLine("We will get back to u soon");

            }
            
            


            Console.Read();
            

        }
    }
}
