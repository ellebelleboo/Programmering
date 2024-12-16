using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift19
{
    internal class Program
    {

        static int SumOfNumbers(int[] array)
        {
            int sum = 0;
            foreach (var number in array)
            {
                sum += number;
            }
            return sum;
        }
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5 };


            int sum = SumOfNumbers(numbers);

            Console.WriteLine("Array length: " + numbers.Length);

            if (sum > -1)
            {
                Console.WriteLine("The total is: " + sum);
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }

            if (numbers.Length > 0)
            {
                if (sum > -1)
                {
                    Console.WriteLine("The total is: " + sum);
                }
                else
                {
                    Console.WriteLine("Cannot add up an empty array");
                }
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }


            Console.ReadLine();
       
        }
    }
}
