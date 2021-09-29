using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MphasisMathsLibrary
{
    public class Operations
    {
        public static int cnt = 1;
        public int counter = 1;
        public void ShowCounter()
        {
            counter += 1;
            Console.WriteLine(counter);
            cnt += 1;
            Console.WriteLine("Cnt = " + cnt);
        }

        //Non static cannot be accessed in the static method
        //Static variable can be accessed in the nonstatic as well as static method
        
        public static void SquareRoot(double no)
        {
            Operations.cnt += 1;
            Console.WriteLine("Counter= "  + Operations.cnt);

            
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
