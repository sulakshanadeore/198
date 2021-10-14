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
