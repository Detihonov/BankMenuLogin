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
                Console.WriteLine("TO DO: Main menu here");
            }

            // about to exit
            Console.WriteLine("Thank you! Visit again.");
        }
    }
}
