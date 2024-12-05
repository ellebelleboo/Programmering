using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter how many times the loop should run: ");
            int X;

            while (!int.TryParse(Console.ReadLine(), out X) || X <= 0 )
            {
                Console.Write("Please enter a valid number");
            }

            for (int i = 1; i <= X; i++)
            {
                Console.WriteLine($"Loop iteration: {i}");
            }

            Console.WriteLine("The loop has finished running.");


            Console.ReadLine();
        }
    }
}
