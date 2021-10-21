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
            studs.Add(new Student { rollno = 9,name="akshay",age=18 });
            studs.Add(new Student { rollno = 2, name = "vishal", age = 19 });
            studs.Add(new Student { rollno = 3, name = "priya", age = 18 });
            studs.Add(new Student { rollno = 4, name = "ajay", age = 20 });
            studs.Add(new Student { rollno = 5, name = "rishabh", age = 18 });
            studs.Add(new Student { rollno = 6, name = "rishi", age = 19 });
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



            var data = from o in orders
                       let amt = o.qty * o.price
                       group new { o.id,o.price,o.qty,o.name } by amt into groupedData
                       select groupedData ;

            foreach (var item in data)
            {
                
                foreach (var itemdata in item)
                {
                    
                    Console.WriteLine(itemdata.id);
                    Console.WriteLine(itemdata.name);
                    Console.WriteLine(itemdata.qty);
                 Console.WriteLine(itemdata.price);
                }
                Console.WriteLine("Total Amt=" + item.Key);
                Console.WriteLine("-----------");
            }


            Console.Read();

        }
    }
}
