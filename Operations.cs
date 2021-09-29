using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MphasisMathsLibrary
{
    public class Operations
    {
        public static void SquareRoot(double no)
        {
            double ans=Math.Sqrt(no);
            Console.WriteLine(ans);
        }
        public static void cube(double no)
        {
            double ans = no * no * no;
            Console.WriteLine(ans);
        }
        public static void PowerOfNumber(int n, int p)
        {
            double ans=Math.Pow(n, p);
            Console.WriteLine(ans);
        }

    }
}
