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
            //ArrayList list = new ArrayList(5);
            //list.Add(33);
            //list.Add(33.33f);
            //list.Add(56.2333d);
            //list.Add("ABC");
            //list.Add('C');

            //list.Add(33);
            //list.Add(33.33f);
            //list.Add(33.2333d);
            //list.Add("ABC");
            //list.Add('C');

            //int[] i = new int[4] { 10, 20, 30, 40 };
            //list.AddRange(i);

            //ArrayList list1 = new ArrayList();
            //list1.Add(1000);
            //list1.Add(2000);
            //list.AddRange(list1);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("------After removing---------");
            //list.Remove(33);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------remove at---------");
            //list.RemoveAt(1);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //list.RemoveRange(0, 4);
            //Console.WriteLine("--------remove range---------");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //object[] o = new object[] { };
            //Console.WriteLine("----------Array elements------------");
            //o=list.ToArray();
            //foreach (var item in o)
            //{
            //    Console.WriteLine(item);
            //}

            //list.SetRange(0, o);
            //Console.WriteLine("----------List elements------------");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Stack s = new Stack();//LIFO
            //s.Push(56);
            //s.Push(33545);
            //s.Push("hello");
            //s.Push('a');
            //s.Pop();//a
            //object o=s.Peek();//hello
            //Console.WriteLine(o);
            //object[] o1 = new object[] { };
            //o1=s.ToArray();
            //int cnt = s.Count;
            //    //s.Contains(56);
            //    object[] obj = new object[] { };
            //    s.CopyTo(obj, 0);
            //object o2=s.Clone();
            //s.Clear();

            //Queue q = new Queue(10);//FIFO
            //q.Enqueue(345);
            //q.Enqueue(12);
            //q.Dequeue();//345
            //q.Peek();//12
            //q.TrimToSize();//2

            Hashtable t = new Hashtable();
            t.Add(1, 100);
            t.Add(2, 200);
            t.Remove(1);//1-100
            ICollection i=t.Keys;
            foreach (var item in i)
            {
                Console.WriteLine(item);
            }
            ICollection v=t.Values;
            foreach (var item in v)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----Hash table--- ");
            foreach (DictionaryEntry item in t)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("-------Second way-----------");
          IDictionaryEnumerator ie  =t.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Key  +  " "  + ie.Value );
                
                
            }



            Console.Read();


        }
    }
}
