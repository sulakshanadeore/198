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

            Console.WriteLine("Enter Manufacturing Date");
            DateTime dt = Convert.ToDateTime(Console.ReadLine());
            if (dt < DateTime.Now)
            {


                Car mycar = new Car("LXi", "Swift", "Red", 500000, "Petrol", dt);
                mycar.ShowCarDetails();
            }
            else
            {
                Console.WriteLine("date must be smaller than todays date");
                Console.WriteLine("Todays date  = " + DateTime.Now);
                Console.WriteLine("Month =" + DateTime.Now.Month);
                Console.WriteLine("Day= " + DateTime.Now.Day);
                Console.WriteLine("Date= " + DateTime.Now.Date );
                Console.WriteLine("Day of week - " + DateTime.Now.DayOfWeek);
                Console.WriteLine("Dya of Year =" + DateTime.Now.DayOfYear );
                Console.WriteLine("Add 2 days to todays date = " + DateTime.Now.AddDays(2));
            }
            





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
