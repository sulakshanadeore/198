using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializationDemo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace ConsoleApp3
{
    class BinarySerializationDemo
    {
        public static void SerializeBinaryData()
        {
            FileStream fs = new FileStream("tranBinaryDetails.bin", FileMode.Create, FileAccess.Write);

            Payment p = new Payment();
            p.TranID = 2234;
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            p.TranDate = dt;
            p.TranAmt = 10000;
            p.RecipientName = "Raj";
            p.CalculateCashBack();

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, p);
            fs.Close();
            fs.Dispose();


        }

        public static void DeserializeBinaryData()
        {
            FileStream fs = new FileStream("tranBinaryDetails.bin", FileMode.Open, FileAccess.Read);



            BinaryFormatter bf = new BinaryFormatter();
            Payment payobject = (Payment)bf.Deserialize(fs);
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
                    MakingPayment paymentDetails = new MakingPayment(DeserializeBinaryData);
                    paymentDetails();
                    
                    break;
            }


            Console.Read();

        }

        private static void Program_MakePayment()
        {

            SerializeBinaryData();
        }
    }
}
