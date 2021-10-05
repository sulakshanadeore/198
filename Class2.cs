using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    public partial class student
    {
        public int rollno { get; set; }
        private int _v1;

        public void M1()
        {
            P1();

        }


        partial void P1()
        {
            _v1 = 10;
            Console.WriteLine("Hello");
            Console.WriteLine(_v1);

        }

    }
}
