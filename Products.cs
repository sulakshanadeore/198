using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Products
    {
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


        internal void CalculatePriceAfterDiscount(float price, int qty)
        {

            if (qty>10)
            {
                Discount= (price * qty) * .05 ;
                InvAmt = (price * qty) - Discount;
            }
            else
            {
                InvAmt = (price * qty);
            }
        }





    }
}
