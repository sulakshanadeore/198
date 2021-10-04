using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdaDemos;
namespace LambdaDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths m = new Maths();
            AddDelegate a = new AddDelegate(m.DoAddition);
          int a1= a(10, 100);
            Console.WriteLine(a1);


            //Anonymous method
            AddDelegate aDel = delegate (int b, int c)
            {
                return b + c;
            };
            int v=aDel.Invoke(10, 100);
            Console.WriteLine(v);

            //public delegate int StringLength(string s);
            //anonymous methods are simple way to work with delegates
            Console.WriteLine("----------------------------------------");
            StringLength str = delegate (string y) {
                int i = y.Length;
                return i;
            };


            int len=str("Hello");
            Console.WriteLine(len);
            Console.WriteLine("----------------Working with Func lambda and Action Lambda--------------------------");

            ////public delegate int AddDelegate(int i, int j);
            //Last in the list is return type
            //public delegate int StringWorking(string a,char b);
            //Func<string,char,int> 
            
            Func<int, int, int> AppAddition = delegate (int i, int j) { return i + j; };
            int myans=AppAddition(10, 20);
            Console.WriteLine(myans);
            Action<int, int> AppAddition1 = delegate (int i, int j) { int ans= i + j;
                Console.WriteLine(ans);
            };
            AppAddition1(100, 200);

            Predicate<string> checkIfAppleIsString = delegate (string fruitname)
            {
                if (fruitname == "Apple")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            bool anscheck=checkIfAppleIsString("Banana");
            Console.WriteLine(anscheck);

            Console.WriteLine("------------------------------------------------------");
                                                                    

            //public delegate int AddDelegate(int i, int j);
            //=>goes to/lambda symbol


            //(same parameter names) => { }
            //(diff parameter names) => { }
            //(type with parameter names) => { }
            //(type with parameter names) => single statement;




            //Lambda Expressions
            AddDelegate del =(i, j)=>{ return i + j; };
            AddDelegate del1 = (y,z ) => { return y + z; };
            AddDelegate del2 = (int p, int q) => { return p + q; };
            AddDelegate del3 = (int p, int q) =>  p + q;
            AddDelegate del4 = (int p, int q) => 
            {
                int ans=p + q;
            //    Console.WriteLine(ans);
            //Console.WriteLine("Answer of p + q=" +ans);
                return ans;
            };

            Console.WriteLine("Lambda invokation");
            int answer=del1(10, 20);
            Console.WriteLine(answer);

            answer = del2(10, 20);
            Console.WriteLine(answer);

            answer = del3(10, 20);
            Console.WriteLine(answer);

            answer = del4(10, 20);
            Console.WriteLine(answer);

            Console.WriteLine("-------------------------------------");
            List<int> listint = new List<int>(5) {3,4,25,2,40 };

            //IEnumerable<int> ie=listint.Where(x =>
            //{
            //    if (x % 2 == 0)
            //        return true;
            //    else
            //        return false;
            //});
            //Console.WriteLine("Even nos are");
            //foreach (var item in ie)
            //{
            //    Console.WriteLine(item);
            //}

            //When lamdba  has return type-- its called function lambda---- Func<>
            //When lambda has no return type(void)----its called Action Lambda-- Action<>
            //When lamdba  has return type & its bool its called Predicate lambda-- Predicate
            List<int> evenlist = new List<int>();
            evenlist =listint.Where(x =>
            {
                if (x % 2 == 0)
               return true;
               else
                    return false;
            }).ToList();

            









            Console.Read();

        }
    }
}
