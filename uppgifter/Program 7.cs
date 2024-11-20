using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__uppgift7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter <= 5)

            {
                Console.WriteLine("Counter value: " + counter);

                counter++;
            }
            Console.WriteLine("The loop has finished");


            Console.ReadLine();
        }
    }
}
