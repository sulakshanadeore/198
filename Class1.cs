using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Maths
    {
        public void SwapNos(int i, int j)
        {
            Console.WriteLine("Before Swapping...");
            Console.WriteLine("I= " + i);//No1
            Console.WriteLine("J=" + j);//No2
            int k = i;
            i = j;
            j = k;
            Console.WriteLine("After Swapping...");
            Console.WriteLine("I= " + i);
            Console.WriteLine("J=" + j);

        }
        public void SwapByReference(ref int i, ref int j)//address get passed
        {
            Console.WriteLine("Before Swapping...");
            Console.WriteLine("I= " + i);//No1
            Console.WriteLine("J=" + j);//No2
            int k = i;
            i = j;
            j = k;
            Console.WriteLine("After Swapping...");
            Console.WriteLine("I= " + i);
            Console.WriteLine("J=" + j);

        }


        public double AreaOfCircle(int r,out  double p)
        {
            p = 2 *(Math.PI * r);
            return Math.PI*r*r;


        }


        public void Area(int r, out int p, out double a)
        {
            p = Convert.ToInt32(2 * (Math.PI * r));
            a=Math.PI* r*r;
        }

    }
}
