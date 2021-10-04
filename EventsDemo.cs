using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesDemo;
namespace EventsDelegatesDemo
{
    class EventsDemo
    {
        public static event StringWorking DoEvent;
        static void Main(string[] args)
        {

            Maths m1 = new Maths();
            DoEvent += EventsDemo_DoEvent;
            DoEvent("Hello", "Sita");//invoking event passing actual parameters

            //De-couple---- remove from  each other (-=)
            //Couple----add each other(+=)


           //DoEvent  += new StringWorking(m1.ReplaceStrings);
           // DoEvent("Hello", "Sita");
            //int ans=DoEvent(10, 20);
            //Console.WriteLine(ans);

            //StringWorking[] delarr1 = new StringWorking[3] { m1.ConcatStrings, m1.ReplaceStrings, m1.LengthOfStrings };
            //StringWorking finalDel1 = (StringWorking)MulticastDelegate.Combine(delarr1);
            // DoEvent = finalDel1;//subscribing to event
            //DoEvent("Hello", "Sita");//Invoke the event
            Console.Read();


            

        }

        private static void EventsDemo_DoEvent(string s1, string s2)
        {
            //throw new NotImplementedException();
            Maths m1 = new Maths();
            StringWorking[] delarr1 = new StringWorking[3] { m1.ConcatStrings, m1.ReplaceStrings, m1.LengthOfStrings };
            StringWorking finalDel1 = (StringWorking)MulticastDelegate.Combine(delarr1);
            finalDel1(s1, s2);

        }
    }
}
