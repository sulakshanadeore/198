using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingDBDataContext context = new ShoppingDBDataContext();
            context.sp_InsertProducts("Logitech Mouse", 2000, "piece");
            context.SubmitChanges();







            //var findcat = (from c in context.Categories
            //              where c.Id == 9
            //              select c).Single();


            //findcat.Catname = "computer Accessories";
            //findcat.Description = "cables,mouse etc";
            //context.SubmitChanges();
            //Console.WriteLine("Updated");





            //Category c = new Category();
            //c.Catname = "Lunch";
            //c.Description = "Lunch";
            //context.Categories.InsertOnSubmit(c);
            //context.SubmitChanges();
            Console.Read();


        }
    }
}
