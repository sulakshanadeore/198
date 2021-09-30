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

        public ElectronicProducts()
        {
            Console.WriteLine("Electronics Products Constructor");
        }

        public ElectronicProducts(int ePid,string ePname)
        {
            Console.WriteLine("Parameterised Electronics");
            base.ProductID = ePid;
            base.ProductName = ePname;

        }
        //private void M1()
        //{
        //    base.GSTCalculate();
        //}

    }

    //Multi-level
    public class LaptopAccessories : ElectronicProducts
    {
        //Products+ Electronic Products

        static LaptopAccessories()
        {
            Console.WriteLine("Static constructor of Laptops");

        }
        public LaptopAccessories()
        {
            Console.WriteLine("Defualt of Laptops");
        }

        string _ModelName;
        public LaptopAccessories(string model)
        {
            Console.WriteLine("Parameterised of Laptop..model assigned");
            _ModelName = model;
        }

        
    }
    public class FMCGProducts:Products
    {
        private void M2()
        {
            MethodProtectedInternal();
        }

    }
}
