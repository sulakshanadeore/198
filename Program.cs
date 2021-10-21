using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXMLDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //DataSet1TableAdapters.CategoriesTableAdapter da = new DataSet1TableAdapters.CategoriesTableAdapter();
            //DataSet1.CategoriesDataTable dt = da.GetData();
            //dt.WriteXml("categoriesData.xml");

            //DataSet1TableAdapters.ProductsTableAdapter da = new DataSet1TableAdapters.ProductsTableAdapter();
            //DataSet1.ProductsDataTable dt = da.GetData();
            //dt.WriteXml("ProductsData.xml");



            //string path = @"D:\Sulakshana\198-Mphasis\C#\LinqToXMLDemo\LinqToXMLDemo\Empdata.xml";
            //XDocument xdocument = XDocument.Load(@"D:\Sulakshana\198-Mphasis\C#\LinqToXMLDemo\LinqToXMLDemo\Empdata.xml");
            //List<XElement> employees = xdocument.Elements().ToList();
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}

            //Using Xelement
            //XElement xelement = XElement.Load(@"D:\Sulakshana\198-Mphasis\C#\LinqToXMLDemo\LinqToXMLDemo\Empdata.xml");
            //IEnumerable<XElement> employees = xelement.Elements();
            ////// Read the entire XML
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}

            //Console.WriteLine("--------------------------------");
            //IEnumerable<XElement> employeesNames = xelement.Elements();
            //Console.WriteLine("List of all Employee Names :");
            //foreach (var employee in employeesNames)
            //{
            //    Console.WriteLine(employee.Element("Name").Value);
            //}


            //Console.WriteLine("------------------");

            //XElement xelement1 = XElement.Load(@"D:\Sulakshana\198-Mphasis\C#\LinqToXMLDemo\LinqToXMLDemo\Empdata.xml");
            //var name = from nm in xelement1.Elements("Employee")
            //           where (string)nm.Element("Gender") == "Male"
            //           select nm;
            //Console.WriteLine("Details of Male Employees:");
            //foreach (XElement xEle in name)
            //{
            //    Console.WriteLine(xEle);
            //}
            //Console.WriteLine("-------------------");

            //XElement xelement = XElement.Load(@"D:\Sulakshana\198-Mphasis\C#\LinqToXMLDemo\LinqToXMLDemo\Empdata.xml");
            //var homePhone = from phoneno in xelement.Elements("Employee")
            //                where (string)phoneno.Element("Phone").Attribute("Type") == "Home"
            //                select phoneno;
            //Console.WriteLine("List HomePhone Nos.");
            //foreach (XElement xEle in homePhone)
            //{
            //    Console.WriteLine(xEle.Element("Phone").Value);
            //}


            Console.Read();
           
        }
    }
}
