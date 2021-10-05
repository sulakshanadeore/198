using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SerializationDemo;
using System.Runtime.Serialization.Formatters.Soap;
namespace ConsoleApp3
{
    class SoapDemo
    {
        //SOAP----- Simple object Access Protocol
        static void Main(string[] args)
        {
            //SerializeSoap();
            FileStream fs = new FileStream("tranBinaryDetails.xml", 
FileMode.Open, FileAccess.Read);
                  

            SoapFormatter sf = new SoapFormatter();
            Payment payobject=(Payment)sf.Deserialize(fs);
            Console.WriteLine("Transaction ID= " + payobject.TranID);
            Console.WriteLine("date of transaction= " + payobject.TranDate);
            Console.WriteLine("Tranamt= " + payobject.TranAmt);
            Console.WriteLine("cashback= " + payobject.CashBack);
            Console.WriteLine("Recipeint= " + payobject.RecipientName);
            fs.Close();
            fs.Dispose();

            Console.Read();

        }

        private static void SerializeSoap()
        {
            FileStream fs = new FileStream("tranBinaryDetails.xml", FileMode.Create, FileAccess.Write);

            Payment p = new Payment();
            p.TranID = 2234;
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            p.TranDate = dt;
            p.TranAmt = 10000;
            p.RecipientName = "Raj";
            p.CalculateCashBack();

            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, p);
            fs.Close();
            fs.Dispose();
        }
    }
}
