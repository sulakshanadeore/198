using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths m = new Maths();
            //Console.WriteLine("");
            int no1, no2;
            no1 = 100;
            no2 = 200;
            m.SwapNos(no1, no2);//values of the variables
            Console.WriteLine("After returning from the logic");
            Console.WriteLine("No1=" + no1);
            Console.WriteLine("No2=" + no2);//donot get swapped at the actual locations
            Console.WriteLine("-----------------------------------");

            m.SwapByReference(ref no1, ref no2);
            Console.WriteLine("After returning from the logic");
            Console.WriteLine("No1=" + no1);
            Console.WriteLine("No2=" + no2);//get swapped at the actual locations
            Console.WriteLine("-----------------------------------");
            double peri,area;
            
            area=m.AreaOfCircle(2, out peri);
            Console.WriteLine("Perimeter= "  +peri);
            Console.WriteLine("Area= " + area);
            Console.WriteLine("-------------------------------------");
            int p;
            m.Area(2, out p, out area);
            Console.WriteLine();
            Console.WriteLine("Perimeter= " + p);
            Console.WriteLine("Area= " + area);
            Console.WriteLine("-----------------------------------------");
            int a=11;//Struct--- Value
            object o;
            string s = "Hello";//Reference
            o = a;//Boxing---Only value types can be boxed.
            Console.WriteLine("Value of o= "+ o);
            //Bigger type can accomodate a smaller "Value" type.
            //o = s;//Not boxing

            double d1 = 3.14;
            object o1 = d1;//Boxing
            Console.WriteLine("O1= " + o1);//3.14
            double d2;
            d2 = (double)o1;//Unboxing//3.14
            Console.WriteLine("D2=" + d2);
            int h;
            h = (int)o1;//Is this unboxing-----3///casting




            d1 = a;//Implicit conversion










            Console.Read();
        }
    }
}
