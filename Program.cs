using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstBALLayer;
using FirstDALLayer;
namespace FirstConnectivityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            try
            {
                        
            Console.WriteLine("Enter Username");
            login.Username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            login.Password = Console.ReadLine();
            Console.WriteLine("Processing your request for login");

                CustomerLogin customerLogin = new CustomerLogin();
                bool ans=customerLogin.ValidateUser(login);
                if (ans==true)
                {
                    Console.WriteLine("Welcome " + login.Username);

                    Console.WriteLine("Do u want to add a new product");
                    bool userans = Convert.ToBoolean(Console.ReadLine());
                    if (userans==true)
                    {
                        ProductsBAL bal = new ProductsBAL();
                        Console.WriteLine("Enter Prodname");
                        bal.Prodname = Console.ReadLine();

                        Console.WriteLine("Enter Product Price");
                        bal.Price =Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Enter UOM");
                        bal.UOM = Console.ReadLine();

                        ProductsDAL dal = new ProductsDAL();
                        dal.InsertProducts(bal);
                        Console.WriteLine("Record aded successfully....");

                    }



                }
                else
                {
                    Console.WriteLine("Pls check ur credentials");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();


        }
    }
}
