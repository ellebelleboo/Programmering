using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 1, num2 = 2, num3 = 3, num4 = 1;
            bool isTrue = true;

            bool resultA = isTrue && (num1 > num3 && num2 > num4);
            Console.WriteLine("Result of logical AND: " + resultA);

            bool resultB = isTrue || (num1 > num3 ||  num2 > num4);
            Console.WriteLine("Result of logical OR: " + resultB);

            bool resultC = !isTrue;
            Console.WriteLine("Result of logical NOT: " + resultC);


            bool isNum1GreaterThanNum3 = num1 > num3;
            Console.WriteLine("Is num1 greater than num3? " + isNum1GreaterThanNum3);

            bool isNum2LessThanNum4 = num2 < num4;
            Console.WriteLine("Is num2 less than num4? " + isNum2LessThanNum4);

            bool isNum1EqualToNum4 = num1 == num4;
            Console.WriteLine("Is num1 equal to num4? " + isNum1EqualToNum4);

            bool isNum2NotEqualToNum3 = num2 != num3;
            Console.WriteLine("Is num2 not equal to num3? " + isNum2NotEqualToNum3);


            bool expression1 = (num1 > num3) && (num2 < num4);
            Console.WriteLine("Expression1 result: " + expression1);

            bool expression2 = (num1 < num3) || (num2 > num4);
            Console.WriteLine("Expression2 result: " + expression2);





            Console.ReadLine();


        }
    }
}
