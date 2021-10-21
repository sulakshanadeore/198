using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Xml.Linq;
using FirstBALLayer;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> intlist = new List<int>();
            //intlist.Add(111);
            //intlist.Add(100);
            //intlist.Add(4000);
            //intlist.Add(2000);
            //intlist.Add(1);
            //intlist.Add(300);

            ////select i from intlist
            //var d = from i in intlist
            //        where i % 2 == 0
            //        orderby i descending
            //        select i;

            //var d = intlist.Where(i => i % 2 == 0).OrderByDescending(i=>i);



            //foreach (var item in d)
            //{
            //    Console.WriteLine(item);
            //}




            //foreach (var item in intlist)
            //{
            //    Console.WriteLine(item);
            //}


            //List<ProductsBAL> products = new List<ProductsBAL>();

            //products.Add(new ProductsBAL {Prodid=1,Prodname="Mobile",Price=10000 });

            //ProductsBAL b1 = new ProductsBAL();
            //b1.Prodid = 2;
            //b1.Prodname = "Power Bank";
            //b1.Price = 7000;
            //products.Add(b1);

            //products.Add(new ProductsBAL { Prodid = 3, Prodname = "Camera", Price = 20000 });

            //products.Add(new ProductsBAL { Prodid = 4, Prodname = "Watch", Price = 15000 });

            //products.Add(new ProductsBAL { Prodid = 5, Prodname = "Laptop", Price = 45000 });

            //var plist = from p in products
            //            where p.Price >=10000 && p.Price <=20000 
            //            select p;

            //var plist = products.Where(p => p.Price >= 10000 && p.Price <= 20000).OrderBy(p=>p.Price);

            //foreach (var item in plist)
            //{
            //    Console.WriteLine(item.Prodid);
            //    Console.WriteLine(item.Prodname);
            //    Console.WriteLine(item.Price);
            //}

            List<Student> studs = new List<Student>();
            studs.Add(new Student());
            studs.Add(new Student { rollno = 9,name="akshay",age=18 });
            studs.Add(new Student { rollno = 2, name = "vishal", age = 19 });
            studs.Add(new Student { rollno = 3, name = "priya", age = 18 });
            studs.Add(new Student { rollno = 4, name = "ajay", age = 20 });
            studs.Add(new Student { rollno = 5, name = "rishabh", age = 18 });
            studs.Add(new Student { rollno = 6, name = "hari", age = 19 });
            studs.Add(new Student { rollno = 7, name = "hari", age = 20 });
            studs.Add(new Student { rollno = 1, name = "tina", age = 18 });



            //var studdata = from s in studs
            //               group s by s.age;
            //groups 3  one for 18, second for 19,3 fro 20----- (key---3)

            //var studdata = studs.GroupBy(s => s.age);

            //foreach (var agegroup in studdata)
            //{
            //    Console.WriteLine("Age group = "  + agegroup.Key);
            //    var orderedData=agegroup.OrderBy(y => y.rollno);
            //    foreach (var stud_item in orderedData)
            //    {
            //        Console.WriteLine(stud_item.rollno + "  "+ stud_item.name +  "    " + stud_item.age);
            //        //Console.WriteLine(stud_item.name);
            //        //Console.WriteLine(stud_item.age);
            //    }
            //    Console.WriteLine("----------------------------");
            //}



        
            //14000+42000+7000+8000
            List<ProductOrders> orders = new List<ProductOrders>();
            orders.Add(new ProductOrders {id=1,name="Mobile",qty=2,price=7000 });
            orders.Add(new ProductOrders { id = 1, name = "watch", qty = 3, price = 14000 });

            orders.Add(new ProductOrders { id = 2, name = "Mobile", qty = 1, price = 7000 });

            orders.Add(new ProductOrders { id = 2, name = "powerbank", qty = 1, price = 8000 });


            //var data = from o in orders
            //           group o by o.id;



            //foreach (var ordergroup in data)
            //{
            //    Console.WriteLine("order id =  " + ordergroup.Key);

            //    foreach (var item in ordergroup)
            //    {
            //        Console.WriteLine(item.name +  "   "+ item.qty + "   "+ item.price );


            //    }
            //    Console.WriteLine("--------------------");
            //}


            //var orderamt = from o in orders
            //               let amt = o.qty * o.price
            //               select amt;

            //foreach (var item in orderamt)
            //{
            //    Console.WriteLine(item);
            //}



            //var data = from o in orders
            //           let amt = o.qty * o.price
            //           group new { o.id,o.price,o.qty,o.name } by amt into groupedData
            //           select groupedData ;

            //foreach (var item in data)
            //{

            //    foreach (var itemdata in item)
            //    {

            //        Console.WriteLine(itemdata.id);
            //        Console.WriteLine(itemdata.name);
            //        Console.WriteLine(itemdata.qty);
            //     Console.WriteLine(itemdata.price);
            //    }
            //    Console.WriteLine("Total Amt=" + item.Key);
            //    Console.WriteLine("-----------");
            //}



            //Console.WriteLine("Individual prices");
            //var prices = from p in orders
            //             select p.price;
            //foreach (var item in prices)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("--------price * qty----------");
            //var result1 = from p in orders
            //              select new { amt = p.price * p.qty };

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item.amt);

            //}
            //Console.WriteLine("-------------Total------------");
            //var  result2 = (from p in orders
            //              select new { amt = p.price * p.qty }).ToList();

            //Console.WriteLine("Total of amt's=  " + result2.Sum(p=>p.amt));

            //Console.WriteLine("-------Aggregate --------");

            //var result = from p in orders
            //             select p.price;



            //Console.WriteLine("Sum of prices= " + result.Sum());
            //Console.WriteLine("Average= " + result.Average());
            //Console.WriteLine("Max= " + result.Max());
            //Console.WriteLine("Min= " + result.Min());
            //Console.WriteLine("Count= " + result.Count());
            //Console.WriteLine("contains= " + result.Contains(5000));
            //Console.WriteLine("Element at= " + result.ElementAt(2));



            //Single/SingleOrDefault/FirstBALLayer/Firstordefault
            foreach (var item in studs)
            {
                Console.WriteLine(item.rollno + "  "+ item.name + "   "+ item.age);
            }
            Console.WriteLine("----------Single-------");

            var singledata = (from s in studs
                              where s.rollno ==1
                              select s).Single();
            Console.WriteLine(singledata.rollno);
            Console.WriteLine(singledata.name);
            Console.WriteLine(singledata.age);
            Console.WriteLine("------Single or SingleOrdefault/Last or LastOrDefault--------Firs/FirstOrDefault-----");
            var singleDefaultData = (from s in studs
                                     where s.name == "tina"
                                     select s).First();
           
            Console.WriteLine(singleDefaultData.rollno);
            Console.WriteLine(singleDefaultData.name);
            Console.WriteLine(singleDefaultData.age);
            Console.WriteLine("-----------------");

            List<Nullable<int>> mlist = new List<Nullable<int>>()
            { null, 1, 23, 2, 2234,1000, 23420 };
            var t = (from t1 in mlist
                     orderby t1
                     select t1).LastOrDefault(t1 => t1 > 50);

            Console.WriteLine(t);
            Console.Read();

        }
    }
}
