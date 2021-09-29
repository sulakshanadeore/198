using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MphasisMathsLibrary
{
    public class Car
    {
        //properties--color,model,name,price,fuelType,etc
        //Behavior-- Drive,ApplyBrake,Reverse,standStill
        //Events---Start,Stop,Accelerate,ChangeGear

        //Variable is used to store data, and do operations on data
        //Constant---- a value that won't change
        string color;
        string model;
        string name;
        string fuelType;
        double price;
        double average;

        public Car()
        {

        }

        //parameter and variable names are same--- this keyword is used for variable
        public Car(string carname,string carcolor)
        {
            color = carcolor;
            name = carname;
        }

        //Constructor chaining--- parameter names must match and sequence also shud match
        public Car(string model, string carname,string carcolor):this(carname, carcolor)
        {
            this.model = model;
            //Console.WriteLine(this.color);
            //Console.WriteLine(this.name);
            //Console.WriteLine(this.model);
        }
        public Car(string model, string carname, string carcolor,double price,string fuelType):this(model,carname,carcolor)
        {
            this.fuelType = fuelType;
            this.price = price;
            //Console.WriteLine(this.fuelType);
            //Console.WriteLine(this.price);
            //Console.WriteLine(this.average);
        }


        public Car(string model,double p)
        {
            this.model = model;
            this.price = p;
        }

        public void ShowCarDetails()
        {
            Console.WriteLine("car Color =" + color);
            Console.WriteLine("Model" + model);
            Console.WriteLine(name);
            Console.WriteLine(fuelType);
            if (fuelType=="Petrol")
            {
                average = 20;
            }
            else
            {
                average = 19;
            }
            Console.WriteLine(average);
            Console.WriteLine(name);
            Console.WriteLine(price);
        }



    }
}
