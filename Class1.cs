using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    //public void CalculateCashBack()
    public delegate void MakingPayment();
    public class Customer
    {
        //properties of customer
        

        public void PlaceOrder()
        {
            //Code
            Console.WriteLine("Order is placed.... now processing your payment");

        }



    }




    [Serializable()]
    public class Payment
    {

        public int TranID { get; set; }
        public DateTime TranDate { get; set; }
        public int TranAmt { get; set; }
        public string RecipientName { get; set; }
        public int CashBack { get; set; }

        public void CalculateCashBack()
        {
            if (TranAmt >= 10000 & TranAmt <= 20000)
            {
                CashBack = 100;
            }
            else if (TranAmt > 20000)
            {
                CashBack = 200;
            }
            else
            {
                CashBack = 0;
            }

        }



    }
}
