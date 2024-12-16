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

            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Array.Sort(numbers);
            Console.WriteLine("\nSorted Array:");

            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Array.Reverse(numbers);
            Console.WriteLine("\nReversed Array:");

            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int indexToRemove = Array.IndexOf(numbers, 78);
            if (indexToRemove != -1)
            {
                numbers = numbers.Where((val, idx) => idx != indexToRemove).ToArray();
            }
            Console.WriteLine("\nArray after removing 78:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int indexOf34 = Array.IndexOf(numbers, 34);
            if (indexOf34 != -1)
            {
                Console.WriteLine($"\nIndex of 34: {indexOf34}");
            }
            else
            {
                Console.WriteLine("\nNumber 34 does not exist in the array.");



                Console.ReadLine();
        }
    }
}
