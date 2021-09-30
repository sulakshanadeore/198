using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2//Acompany
{
    public abstract class Employee
    {
        //abstract method(non concrete) & concrete methods
        //Every abstract class must have atleast one abstract member
        //abstract classes are meant for inheritance
        //Abstract methods/members only in abstract class


        public abstract void M1() { }
        
        public void M2()
        {

            Console.WriteLine("Code is here");
        }


    }


   public interface I1
    {
        //1) Interface is a contract
        //It can behave(behaviors) differently with different classes()
        //different behavior to same method in different classes

        //2. Make Interface Public but not member
        //Property declaration in interface allowed--- yes
        //Variable declaration in interface allowed--- not allowed
        //Constant declaration in interface allowed-- not allowed
        //Access specifiers not allowed with any members

            //Interface cannot inherit from Class, it can inherit only from one or more interfaces.

            //Even cannot inherit from abstract class

        //const float pi = 3.14f;
        void Pay(int amt, string modeOfPayment);

        //private int no1;

         int No1 { get; set; }
        //{
            //get { return no1; }
            //set { no1 = value; }
        //}


    }

    public class Customer : Employee,I1
    {
        public int No1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void M1()
        {
            throw new NotImplementedException();
        }

        public void M3()
        {

            base.M2();
        }

        public void Pay(int amt, string modeOfPayment)
        {
            //Cash on Delivery
        }
    }
    public class GoldCustomer : Customer, I1
    {
        public void Pay(int amt, string modeOfPayment)
        {
           //Mode--- CreditCard + COD
           //Payment Gateway
        }
        public new int No1 { get { return base.No1; } set { base.No1=value; } }
    }


    public class  PremiumCustomer:Customer,I1
    {
        //Mode---- UPI + COD + creditCard
        //UPI Payment Gateway
    }


}
