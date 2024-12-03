using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 1, num2 = 2, num3 = 3, num4 = 4, num5 = 5, num6 = 6;

            int sum = num1 + num2;
            Console.WriteLine("Sum of num1 and num2 is: " + sum);

            int product = num3 * num4;
            Console.WriteLine("Product of num3 and num4 is: " + product);

            int remainder = num5 % num6;
            Console.WriteLine("Remainder of num5 divided by num6 is: " + remainder);

            int postfixIncrement = ++num6;
            Console.WriteLine("Postfix increment on num6: " + postfixIncrement);
            Console.WriteLine("Value of num6 after postfix: " + num6);

            int prefixIncrement = ++num6;
            Console.WriteLine("Prefix increment on num6: " + prefixIncrement);

            int postfixDecrement = num6--;
            Console.WriteLine("Postfix decrement on num6: " + postfixDecrement);
            Console.WriteLine("Value of num6 after postfix: " + num6);

            int prefixDecrement = --num6;
            Console.WriteLine("Prefix decrement on num6: " + prefixDecrement);


            int subtraction = num5 - num6;
            Console.WriteLine("Subtraction of num5 and num6: " + subtraction);


            int multiplication = num5 * num6;
            Console.WriteLine("Multiplication of num5 and num6: " + multiplication);

            int division = num5 / num6;
            Console.WriteLine("Division of num5 by num6: " + division);

            int modulus = num5 % num6;
            Console.WriteLine("Remainder of num5 divided by num6: " + modulus);



            Console.ReadLine();


        }
    }
}
