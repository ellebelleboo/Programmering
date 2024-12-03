using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 45, 12, 78, 34, 89, 23 };

            Console.WriteLine("Orginal Array: ");
            

            Array.Sort(numbers);
            Console.WriteLine("\nSorted Array: ");
            Console.WriteLine(numbers);

            Array.Reverse(numbers);
            Console.WriteLine("\nReversed Array: ");
            Console.WriteLine(numbers);


            

            Console.ReadLine();
        }
    }
}
