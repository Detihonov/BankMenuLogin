using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoginMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************** Bank ********************");
            Console.WriteLine("::Logon Page::");

            // declare variables to store username and password
            string userName = null, password = null;

            // read userName from keyboard
            Console.Write("UserName: ");
            userName = Console.ReadLine(); // John

            if (userName != "")
            {
                // read password from keyboard
                Console.Write("Password: ");
                password = Console.ReadLine(); 
            }

            // chack username and password
            if (userName.ToLower() == "system" && password == "manager")
            {
                // declare variable to store menu choice
                int mainMenuChoice = -1;
                do
                {
                    Console.WriteLine("\n::Main menu::");
                    Console.WriteLine("1.Customers");
                    Console.WriteLine("2.Accounts");
                    Console.WriteLine("3.Funds Transfer");
                    Console.WriteLine("4.Funds Transfer Statement");
                    Console.WriteLine("5.Account Statement");
                    Console.WriteLine("0.Exit");

                    Console.Write("Enter choice: ");
                    mainMenuChoice = int.Parse(Console.ReadLine());

                    switch (mainMenuChoice)
                    {
                        case 1: CustomersMenu(); break;
                        case 2: break;
                        case 3: break;
                        case 4: break;
                        case 5: break;
                        default: break;
                    }
                } while (mainMenuChoice != 0);
                
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }

                // about to exit
            Console.WriteLine("Thank you! Visit again.");
        }

        static void CustomersMenu()
        {
            // variable to store customers menu choice
            int customerMenuChoice = -1;
            do
            {
                Console.WriteLine("\n::Customers menu::");
                Console.WriteLine("1.Add Customer");
                Console.WriteLine("2.Delete Customer");
                Console.WriteLine("3.Upadate Customer");
                Console.WriteLine("4.View Customers");
                Console.WriteLine("0.Back to Main Menu");

                // accept customers menu choice
                Console.Write("Enter choice: ");
                customerMenuChoice = Convert.ToInt32(Console.ReadLine());
            } while (customerMenuChoice != 0);
        }
    }
}
