using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a message: ");
            string message = Console.ReadLine();

            Console.WriteLine("Original message:");
            Console.WriteLine(message);

            Console.WriteLine("Message in reverse order:");

            char[] reversedMessageArray = message.ToCharArray();
            Array.Reverse(reversedMessageArray);
            Console.WriteLine(new string(reversedMessageArray));

            Console.WriteLine("Message from top to bottom :");
            foreach (char letter in message)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine("Message from top to bottom in reverse:");
            foreach (char letter in reversedMessageArray)
            {
                Console.WriteLine(letter);
            }


            Console.ReadLine();

        }
    }
}
