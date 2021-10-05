using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    public class Employee
    {
        int _empid;
        public int Empid
        {
            get { return _empid; }
            set {
                //if (value <= 0)
                //{
                //    throw new NullReferenceException();
                //}
                //else
                //{
                    _empid = value;
                //}
                

            }
        }
    }
}
