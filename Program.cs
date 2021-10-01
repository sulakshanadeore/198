using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(5);
            list.Add(33);
            list.Add(33.33f);
            list.Add(56.2333d);
            list.Add("ABC");
            list.Add('C');

            list.Add(33);
            list.Add(33.33f);
            list.Add(33.2333d);
            list.Add("ABC");
            list.Add('C');
            
            int[] i = new int[4] { 10, 20, 30, 40 };
            list.AddRange(i);

            ArrayList list1 = new ArrayList();
            list1.Add(1000);
            list1.Add(2000);
            list.AddRange(list1);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------After removing---------");
            list.Remove(33);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------remove at---------");
            list.RemoveAt(1);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.RemoveRange(0, 4);
            Console.WriteLine("--------remove range---------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            object[] o = new object[] { };
            Console.WriteLine("----------Array elements------------");
            o=list.ToArray();
            foreach (var item in o)
            {
                Console.WriteLine(item);
            }

            list.SetRange(0, o);
            Console.WriteLine("----------List elements------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.Read();


        }
    }
}
