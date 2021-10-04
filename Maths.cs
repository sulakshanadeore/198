using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    //declare the delegate
    public delegate void StringWorking(string s1, string s2);
    public delegate int AddDelegate(int x, int y);
    public class Maths
    {

        public void ConcatStrings(string fs, string ss)
        {
           string newstr=string.Concat(fs, ss);
            Console.WriteLine(newstr);
        }


        public void ReplaceStrings(string fs, string os)
        {
            string r1=fs.Replace('e', 'a');
            string r2=os.Replace('i', 'e');
            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }


        public void LengthOfStrings(string fs, string s)
        {
            int l=fs.Length;
            int l1 = s.Length;
            int totalLength = l + l1;
            Console.WriteLine(totalLength);

        }
        
        public int Addition(int i, int j)
        {
            return i + j;
        }

        public int Subtraction(int i, int j)
        {
            int ans = 0;
            if (i!=0)
            {
                ans= i - j;
            }
            return ans;
            
        }
    }
}
