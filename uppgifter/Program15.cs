using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 10, 20, 30, 40, 50 };

            int maxValue = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }

            Console.WriteLine("The maximum value is: " + maxValue);


            Console.ReadLine();

        }
    }
}
