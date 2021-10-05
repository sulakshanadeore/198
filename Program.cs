using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializationDemo;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp3
{
    class Program
    {


        static void SerializeObjectData()
        {
            FileStream fs = new FileStream("tranDetails.xml", FileMode.Create, FileAccess.Write);

            Payment p = new Payment();
            p.TranID = 2234;
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            p.TranDate = dt;
            p.TranAmt = 10000;
            p.RecipientName = "Raj";
            p.CalculateCashBack();

            XmlSerializer xs = new XmlSerializer(typeof(Payment));
            xs.Serialize(fs, p);
            fs.Close();
            fs.Dispose();
            Console.WriteLine("Payemnt received ... Ur order will reach u soon");

        }



        public static void DeserializeObjectData() {
            FileStream fs = new FileStream("tranDetails.xml", FileMode.Open, FileAccess.Read);

            XmlSerializer xs = new XmlSerializer(typeof(Payment));
            Payment payobject = (Payment)xs.Deserialize(fs);
            Console.WriteLine("Transaction ID= " + payobject.TranID);
            Console.WriteLine("date of transaction= " + payobject.TranDate);
            Console.WriteLine("Tranamt= " + payobject.TranAmt);
            Console.WriteLine("cashback= " + payobject.CashBack);
            Console.WriteLine("Recipeint= " + payobject.RecipientName);
            fs.Close();
            fs.Dispose();


        }


        public static event MakingPayment MakePayment;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to make payment , 2 to see the payment details");
            int c = Convert.ToInt32(Console.ReadLine());

            switch (c)
            {
                case 1:
                    Customer cust = new Customer();
                    cust.PlaceOrder();
                 
                    MakePayment += Program_MakePayment;
                    MakePayment();
                    break;
                case 2:
                    Console.WriteLine("The following are ur payment details");
                    MakingPayment paymentDetails = new MakingPayment(DeserializeObjectData);
                    paymentDetails();
                    //DeserializeObjectData();
                    break;
            }
            
            

            
            



            Console.Read();


        }

        private static void Program_MakePayment()
        {
            
            SerializeObjectData();
        }
    }
}
