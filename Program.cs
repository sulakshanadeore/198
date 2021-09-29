using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MphasisMathsLibrary;
namespace MyFirstconsolApp
{
    class Program
    {
        int s;

        static void Main(string[] args)
        {
            //Car mycar = new Car();//Object creation

            //Default constructor
            //Its created by default when class is created


            Car mycar = new Car("LXi", "Swift", "Red",500000,"Petrol");

            mycar.ShowCarDetails();





            //Console.WriteLine("Program Class = " + Operations.cnt);//1
            ////Operations.cnt = Operations.cnt + 1;
            ////Console.WriteLine(Operations.cnt);
            ////Operations.cube(2);
            //Operations.SquareRoot(144);
            //Console.WriteLine("Program class=" + (Operations.cnt +1));
            //Operations o = new Operations();
            //o.ShowCounter();

            //Program p = new Program();
            //p.s
            //Operations.PowerOfNumber(2, 4);
            Console.Read();

        }
    }
}
