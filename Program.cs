using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesDemo;
namespace EventsDelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Maths m = new Maths();
            //pass address of method to delegate
            //If a  delegate calls single method---- Unicast delegate
            AddDelegate del = new AddDelegate(m.Subtraction);

            //invoke the delegate 
            //int delans=del(20, 2);
            int delans=del.Invoke(20, 2);

            Console.WriteLine(delans);


            //Multi-cast---- call multiple methods by using single delegate
            //Multi-cast delegate return type must always be void.
            //Chain of  multiple method address-----so that they get called one AFTER the other--- synchronous invocation
            Console.WriteLine("--------------------------");
            StringWorking sw1 = new StringWorking(m.ConcatStrings);
            StringWorking sw2 = new StringWorking(m.ReplaceStrings);
          StringWorking sw3=(StringWorking) MulticastDelegate.Combine(sw1, sw2);


            //sw3("Hello", "Sita");
            sw3.Invoke("Hello", "Sita");

            Console.WriteLine("---------------Array of delegates--------");

            StringWorking[] delarr = new StringWorking[3] {m.ConcatStrings,m.ReplaceStrings,m.LengthOfStrings };
            StringWorking finalDel=(StringWorking)MulticastDelegate.Combine(delarr);
            //finalDel("Hello", "Babita");
            finalDel.Invoke("Hello", "Babita");


            //asynchronous invocation------ one method get called that is taking a long time to execute and so UNTIL it completes we call the next method in the sequence and
            //then check whether first method has completed and as per the status continue accordingly.

            //A_Method(){

            //}
            //B_Method(){    }



            Console.Read();

        }
    }
}
