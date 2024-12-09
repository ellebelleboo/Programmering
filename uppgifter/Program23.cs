using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift23
{
    internal class Program
    {
        //static void Main(string[] args)
        //{

        //    string input = "abc";
        //    int result;
         
        //    try 
        //    {
        //        result = Convert.ToInt32(input);
        //        Console.WriteLine($"Conversion succeeded: {result}");
        //    }
        //    catch (FormatException e)
        //    { 
        //        Console.WriteLine ($"conversion.failed: { e.Message}");
        //    }


        //}

        static bool CustomTryParse(string input, out int result)
        {

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (FormatException e)
            {
                result = 0;
                return false;
            }
        }

        static void UseCustomParse()
        {
            string input = "123";
            if (CustomTryParse(input, out int result))
            {
                Console.WriteLine($"Conversion succeeded: {result}");
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }

        }
    }
}
