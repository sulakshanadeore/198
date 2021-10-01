using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AbstractInterfaceDemo
{
    class MoreArrayMethods
    {
        static void Main(string[] args)
        {
            int[] c = new int[10] { 34, 125, 12566, 235, 6, 61, 23, 465, 987, 875 };

            Array.Sort(c);
            Array.Reverse(c);
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            int[] d = new int[c.Length];
            Array.Copy(c, d, c.Length);
            Console.WriteLine("Copied array");
            foreach (var item in d)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            Array.Clear(d, 0, 5);
            foreach (var item in d)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");
            bool ans=d.Contains(125);
            Console.WriteLine("Does have 125=" + ans);
            Console.WriteLine("-----------------------");
            int cnt=d.Count();
            Console.WriteLine(cnt);
            Console.WriteLine("--------");
            int i=d.ElementAt(6);
            Console.WriteLine(i);
            Console.WriteLine("---------------");
            int value=d.Sum();
            Console.WriteLine(value);
            Console.WriteLine("-----------------");

            //ArrayList--- System.Collections
            ArrayList l = new ArrayList();
            l.Add(34);//object
            l.Add(34.34f);
            l.Add(34.434534d);
            l.Add('A');
            l.Add("Gauri");
            l.Add(new DateTime());
            l.Add(true);

            //List----- System.Collections.Generic
            List<int> li = new List<int>();
            li.Add(45);
            li.Add(35);
            li.Add(322);


            Console.Read();
        }
    }
}
