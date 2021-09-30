using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Derived--EElectronicProducts
    //Base-- Products

    public class ElectronicProducts:Products
    {
        static ElectronicProducts()
        {
            Console.WriteLine("Static of Electronics");
        }

        
        public ElectronicProducts():base()
        {
            Console.WriteLine("Electronics Products Constructor");
            
        }

        public void M1()
        {

        }
        public ElectronicProducts(int pid,string pname):this()
        {
            Console.WriteLine("Parameterised Electronics");
            base.ProductID = pid;
            base.ProductName = pname;

        }
        //private void M1()
        //{
        //    base.GSTCalculate();
        //}

        public override void InsertProductData()
        {
            //base.InsertProductData();
        }

    }

    //Multi-level
    public class LaptopAccessories : ElectronicProducts
    {
        //Products+ Electronic Products

        static LaptopAccessories()
        {
            Console.WriteLine("Static constructor of Laptops");

        }

        public sealed override void InsertProductData()
        {

        }

        public LaptopAccessories()
        {
            Console.WriteLine("Defualt of Laptops");
        }
        public void M1()
        {

        }

        string _ModelName;
        public LaptopAccessories(string model)
        {
            Console.WriteLine("Parameterised of Laptop..model assigned");
            _ModelName = model;
        }

        
    }


    
    public class FMCGProducts:LaptopAccessories
    {

        public override void InsertProductData()
        {
        }

        private void M2()
        {
            MethodProtectedInternal();
        }

    }
}
