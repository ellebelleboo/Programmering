using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            switch (grade)
            {
                case 5:
                    Console.WriteLine("Exellent");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 3:
                    Console.WriteLine("Satisfactory");
                    break;
                case 2:
                    Console.WriteLine("Ok");
                    break;
                case 1:
                    Console.WriteLine("Needs improvement");
                    break;
                case 0:
                    Console.WriteLine("Fail");
                    break;
            }

            Console.ReadLine();
        }
    }
}
