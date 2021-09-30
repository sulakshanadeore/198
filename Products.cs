using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Products
    {
        static Products()
        {
            Console.WriteLine("Static Products");
        }
        public Products()
        {
            Console.WriteLine("Default Products Constructor");
        }

        public Products(int pid,string pname)
        {

            Console.WriteLine("Parameterised Products Constructor");
            this.ProductID = pid;
            this.ProductName = pname;
        }

        private int _prodid;

        public int ProductID
        {
            get { return _prodid; }
            set { _prodid = value; }
        }

        private string _prodname;

        public string ProductName
        {
            get { return _prodname; }
            set { _prodname = value; }
        }

        private float _price;

        public float ProductPrice
        {
            get { return _price; }
            set { _price = value; }
        }

        private int _qty;

        public int Qty
        {
            get { return _qty; }
             set { _qty = value; }
        }

        private double _amt;

        public double InvAmt
        {
            get {
                CalculatePriceAfterDiscount(ProductPrice, Qty);
                return _amt; }
            private set { _amt = value; }
        }

        private double _dis;
       

        public double Discount
        {
            get { return _dis; }
            private set { _dis = value; }
        }


        //Accessible to all the classes in the ClassLibrary1
        internal void CalculatePriceAfterDiscount(float price, int qty)
        {

            if (qty>10)
            {
                Discount= (price * qty) * .05 ;
                InvAmt = (price * qty) - Discount;
                GSTCalculate();
            }
            else
            {
                InvAmt = (price * qty);
            }
        }

        //Accessible in the assembly to only the derived classes and in  the same class
        protected void GSTCalculate()
        {
            Console.WriteLine("Tax calculations done here ");
            MethodProtectedInternal();
        }

        protected internal void MethodProtectedInternal()
        {

        }



    }
}
