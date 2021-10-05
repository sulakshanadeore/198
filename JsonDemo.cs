
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializationDemo;
using System.IO;
using Newtonsoft.Json;
namespace ConsoleApp3
{
    class JsonDemo
    {

        private static void SerializeAsJson()
        {
            Payment p = new Payment();
            p.TranID = 2234;
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            p.TranDate = dt;
            p.TranAmt = 10000;
            p.RecipientName = "Raj";
            p.CalculateCashBack();


            string s = JsonConvert.SerializeObject(p);
            File.WriteAllText("tranDetails.json", s);
            Console.WriteLine("created");
            


        }
        static void Main(string[] args)
        {
            string data=File.ReadAllText("tranDetails.json");
            Payment d=JsonConvert.DeserializeObject<Payment>(data);
            Console.WriteLine("Tran id=" + d.TranID);
            Console.WriteLine("Date =" + d.TranDate);
            Console.WriteLine("Amt = " + d.TranAmt);
            Console.WriteLine("Cashback =" + d.CashBack );
            Console.WriteLine("Recipient Name= "  + d.RecipientName);

            Console.Read();
        }
    }
}
