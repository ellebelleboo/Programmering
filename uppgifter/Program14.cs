using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;

            int[] multiplicationTable = new int[length];

            for (int i = 0; i < length; i++)
            {
                multiplicationTable[i] = num * (i + 1);
            }

            Console.WriteLine($"Multiplication Table for {num}: ");
            foreach (var value in multiplicationTable)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}
