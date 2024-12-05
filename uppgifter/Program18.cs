using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift18
{
    internal class Program
    {

        static double CalculateArea (double width, double height)
            {
            return (width * height) / 2;
            }


        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the width of the triangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double CalculateArea = (width * height) / 2;
            Console.WriteLine("The calculated area is: " + CalculateArea);



            Console.ReadLine();
        }
    }
}
