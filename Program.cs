using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            //object o;
            //Console.WriteLine("Hello world");
            int i,j,k=0;
           // short j;
            Console.WriteLine("Enter a  value for i");
            //Convert string to integer
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for j");
            j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1 to add \n2 to subtract \n3 multiply \n4 divide \n5 exit");
            int choice = Convert.ToInt32(Console.ReadLine());
                   

            switch (choice)
            {
                case 1:
                    k = i + j;
                    break;
                case 2:
                    if(i!=0)
                    k = i -j;
                    break;
                case 3:
                    k = i * j;
                    break;
                case 4:
                    if (j!= 0)
                        k =i /j;
                    break;
                case 5:
                    Environment.Exit(1);
                    break;
                
            }
                   
            
            Console.WriteLine("The answer =" + k);



            //j = Convert.ToInt16(Console.ReadLine());

            Console.ReadLine();



        }
    }
}
