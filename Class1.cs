using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemos
{
    public delegate int AddDelegate(int i, int j);
    public delegate int StringLength(string s);
    public class Maths
    {
        //class code here
        //public int DoAddition(int i, int j)
        //{
        //    return i + j;
        //}

        public int DoAddition(int i, int j)
        {
            int d=Convert.ToInt32(i.ToString() + j.ToString());
            return d;
        }


    }
}
