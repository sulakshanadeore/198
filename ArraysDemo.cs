using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDemo
{
    class ArraysDemo
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {2,35,311,324,12,46,22 };
            int[] b = new int[4];
            b[0] = 13;
            b[1] = 34;
            b[2] = 344;
            b[3] = 34556;

            int[] c = new int[10] {34,125,12566,235,6,61,23,465,987,875 };

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("------------------------------------");
            //var--- Implicitly typed variable
            foreach (var element in c)
            {
                Console.WriteLine(element);
            }


            Console.WriteLine("--------------------------------");
            char[] chars = new char[] { 'A', 'B', 'C', 'D' };

            foreach (var item in chars)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");

            string[] s = new string[] {"Hello","World","Welcome" };
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------");

            string s1 = "Welcome";
            char[] newarr=s1.ToCharArray();
            foreach (var item in newarr)
            {
                Console.WriteLine(item);
            }

            //var j = "sdfsdf";
            Console.Read();




        }
    }
}
