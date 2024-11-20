using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your age: ");
            string userInput = Console.ReadLine();

            int age = Convert.ToInt32(userInput);

            const int legalAge = 18;

            if (age >= legalAge)
            {
                Console.WriteLine("You are an adult.");
            }
            else if (age < legalAge) {
                Console.WriteLine("You are under the legal age.");
            }

            int counter = 1;
            while (counter <= 5)

            {
                Console.WriteLine("Counter value: " + counter);

                counter++;
            }


            counter = 1;
            switch (counter)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;

            }


            var name = "John";

            Console.WriteLine("Welcome, " + name);


            Console.WriteLine("Here are the Results of the loop: ");
            while (counter <= 5)
            {
                Console.WriteLine("Counter value: " + counter);

                counter++;
            }

            Console.WriteLine("Results of the switch statement: ");

            counter = 1;
            switch (counter)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;

            }

            Console.ReadLine();

        }
    }
}
