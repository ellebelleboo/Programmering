using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your password: ");
            string password1 = Console.ReadLine();

            
            Console.Write("Enter your password again: ");
            string password2 = Console.ReadLine();


            if (string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                Console.WriteLine("Please enter a password.");
            }

            else if (password1.Length < 6||password2.Length < 6)
            { 
                Console.WriteLine("Password length must be at least 6 characters.");
            }

            else if (password1 == password2)
            {
                Console.WriteLine("Password match.");
            }
            else
            {
                Console.WriteLine("Passwords do not match.");
            }

            Console.ReadLine();
        }
    }
}
